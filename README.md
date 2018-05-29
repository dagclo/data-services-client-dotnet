# Quadient Data Services Client for C# and .NET

[![Build Status: Linux](https://travis-ci.org/quadient/data-services-client-dotnet.svg?branch=master)](https://travis-ci.org/quadient/data-services-client-dotnet)
[![NuGet](https://img.shields.io/nuget/v/Quadient.DataServices.Api.svg)](https://www.nuget.org/packages/Quadient.DataServices.Api)


This project provides a client package for [Quadient Data Services](https://www.quadient.com/products/quadient-data-services) for the C# programming language.

The client relies heavily on the following dependencies:

 * Newtonsoft.Json (for JSON serialization and deserialization)

## Usage

Here is a simple code snippet demonstrating how to use the client package:

```
using Quadient.DataServices.Api;

...

var credentials = new QuadientCloudCredentials("company", "username", "password");
var client = new Client(credentials);

var response = await client.execute(new AddressCorrection(...));
```

Check out the `DataServicesExample project` folder for more comprehensive examples.