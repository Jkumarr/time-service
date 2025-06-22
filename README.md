# time-service

A .NET real-time Web API demo.

## Overview

**time-service** is a sample project demonstrating how to build a real-time web API using .NET. The service provides the current server time via HTTP endpoints and can be extended to support real-time updates.

## Features

- REST API to get the current server time
- Real-time time updates (optional)
- Simple, clean .NET project structure
- **Unit test project included** (see below)

## Getting Started

### Prerequisites

- [.NET 9 SDK or later](https://dotnet.microsoft.com/download)
- Git

### Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/time-service.git
    cd time-service
    ```

2. Restore dependencies:
    ```sh
    dotnet restore
    ```

3. Run the application:
    ```sh
    dotnet run --project src/time-service/time-service.csproj
    ```

4. The API will be available at `https://localhost:5001` or `http://localhost:5000` (see launch output for actual port).

## Example API Usage

You can use the included `time-service.http` file to test the API endpoints directly from Visual Studio Code using the [REST Client extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client).

### Example from `time-service.http`

```
GET http://localhost:5000/time
Accept: application/json
```

To use:
1. Open `time-service.http` in VS Code.
2. Click "Send Request" above the desired request.

**Expected Response:**
```json
{
  "currentTime": "2025-06-22T12:34:56Z",
  "timeZone": "UTC"
}
```

## Running Tests

This solution includes a unit test project using xUnit:

- To run all tests:
  ```sh
  dotnet test
  ```
- To run only the test project:
  ```sh
  dotnet test tests/TimeService.Tests/TimeService.Tests.csproj
  ```

Test output will indicate the number of tests run and their status.

## Project Structure

- `src/time-service/Program.cs` - Application entry point and configuration
- `src/time-service/time-service.csproj` - Main API project
- `src/time-service/appsettings.json` - Application configuration
- `src/time-service/appsettings.Development.json` - Development configuration
- `time-service.http` - Sample HTTP requests for testing the API
- `tests/TimeService.Tests/` - Unit test project (xUnit)
- `README.md` - Project documentation

## Contributing

Contributions are welcome! Please open issues or submit pull requests.

## License

This project is licensed under the MIT License.