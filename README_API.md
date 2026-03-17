# Native Git Postman API

A sample .NET 8 Web API project built with C#.

## Prerequisites

- .NET 8 SDK or later
- Visual Studio Code or Visual Studio

## Getting Started

### Build the project

```bash
dotnet build
```

### Run the project

```bash
dotnet run
```

The API will be available at `https://localhost:5001` or `http://localhost:5000`

## Project Structure

```
├── Controllers/          # API Controllers
├── Models/              # Data models
├── Services/            # Business logic services
├── Properties/          # Project properties and launch settings
├── Program.cs           # Application entry point
├── appsettings.json     # Configuration settings
└── nativegit-postman.csproj  # Project file
```

## Features

- ASP.NET Core 8.0 Web API
- Dependency Injection
- CORS support
- Structured logging

## Sample Endpoint

### Get Weather Forecast

```
GET /api/weatherforecast
```

Returns a list of weather forecasts for the next 5 days.

## License

This project is licensed under the MIT License.
