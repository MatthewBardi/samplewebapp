// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Hosting;

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello Udeme!");

// app.Run();

// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Configuration;

// var builder = WebApplication.CreateBuilder(args);

// // Read the APP_SETTINGS environment variable
// var appSettingsJson = Environment.GetEnvironmentVariable("APP_SETTINGS");

// if (!string.IsNullOrEmpty(appSettingsJson))
// {
//     // Load the settings from the environment variable
//     builder.Configuration.AddJsonStream(new MemoryStream(Encoding.UTF8.GetBytes(appSettingsJson)));
// }

// // Add other configuration sources if needed
// builder.Configuration.AddJsonFile("appsettings.json", optional: true);

// var app = builder.Build();

// app.MapGet("/", () => "Hello Udeme!");

// app.Run();

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Read the APP_SETTINGS environment variable
var appSettingsJson = Environment.GetEnvironmentVariable("APP_SETTINGS");

if (!string.IsNullOrEmpty(appSettingsJson))
{
    // Load the settings from the environment variable
    builder.Configuration.AddJsonStream(new MemoryStream(Encoding.UTF8.GetBytes(appSettingsJson)));
}

// Add other configuration sources if needed
builder.Configuration.AddJsonFile("appsettings.json", optional: true);

var app = builder.Build();

app.MapGet("/", () => "Hello Udeme!");

app.Run();

