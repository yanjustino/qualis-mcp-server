```markdown
# QualisMcp

## Overview

QualisMcp is a C# project designed to provide tools for retrieving and managing event classifications for the years 2017-2020 in the field of Computer Science. It includes a server (`QualisMcpServer`) and a client (`QualisMcpClient`) that interact to process and retrieve classification data.

## Features

- **Event Classification Information**: Retrieve detailed information about event classifications for the 2017-2020 period.
- **Event Lookup**: Query the classification of a specific event by its acronym.
- **Docker Support**: The server is containerized using Docker for easy deployment.

## Project Structure

- `src/QualisMcpServer`: Contains the server implementation, including tools and logic for event classification.
- `src/QualisMcpClient`: Contains the client configuration for interacting with the server.

## Requirements

- **.NET 9.0 SDK** or later
- **Docker** (for running the server in a containerized environment)

## Setup

### Client

1. Configure the client in `src/QualisMcpClient/.vscode/mcp.json` to point to the server.
2. Use the client to interact with the server.
3. [See how to run MCP Client in VS Code](https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/#configure-and-run-in-vs-code)

## Usage

### Tools

- **Sobre**: Provides general information about event classifications for 2017-2020.
- **Qualis**: Retrieves the classification of a specific event by its acronym.

## Dependencies

- `Microsoft.Extensions.Hosting` (v9.0.4)
- `ModelContextProtocol` (v0.1.0-preview.10)

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Author

Developed by yanjustino.
```