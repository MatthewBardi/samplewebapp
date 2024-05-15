# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app

# Copy from the build stage
COPY --from=build-env /app/out .

# Install curl
RUN apt-get update && \
    apt-get install -y curl

# Set the entry point
ENTRYPOINT ["dotnet", "SampleWebApp.dll"]
