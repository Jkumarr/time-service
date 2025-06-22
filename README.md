# time-service

A .NET real-time Web API demo.

## Overview

**time-service** is a sample project demonstrating how to build a real-time web API using .NET. The service provides the current server time via HTTP endpoints and can be extended to support real-time updates.

## Features

- REST API to get the current server time
- Real-time time updates (optional)
- Simple, clean .NET project structure

## Getting Started

### Prerequisites

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
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
    dotnet run
    ```

4. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## Example API Usage

You can use the included `time-service.http` file to test the API endpoints directly from Visual Studio Code using the [REST Client extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client).

### Example from `time-service.http`

```
### Get current server time
GET http://localhost:5000/time
Accept: application/json
```

To use:
1. Open `time-service.http` in VS Code.
2. Click "Send Request" above the desired request.

**Expected Response:**
```json
{
  "currentTime": "2025-06-22T12:34:56Z"
}
```

## Project Structure

- `Program.cs` - Application entry point and configuration
- `time-service.http` - Sample HTTP requests for testing the API
- `README.md` - Project documentation

## Contributing

Contributions are welcome! Please open issues or submit pull requests.

## License

This project is licensed under the MIT License.