# QualisMcp

## Introduction to Model Context Protocol (MCP)

Model Context Protocol (MCP) is a framework designed to facilitate communication between distributed systems by defining a standardized protocol for exchanging structured data. It enables seamless interaction between clients and servers, focusing on simplicity, scalability, and flexibility. MCP is particularly useful in scenarios where systems need to share complex data models while maintaining a clear and consistent context.

## Overview

By leveraging MCP, the `QualisMcp` project ensures efficient data exchange and robust communication between its server and client components, enabling accurate retrieval and management of event classifications. For more details, visit the [official MCP documentation](https://modelcontextprotocol.io/introduction).

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
