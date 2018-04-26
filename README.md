# Quadient Data Services Client for C# and .NET

[![Build Status: Linux](https://travis-ci.org/quadient/data-services-client-dotnet.svg?branch=master)](https://travis-ci.org/quadient/data-services-client-dotnet)

This project provides a client package for [Quadient Data Services](https://www.quadient.com/products/quadient-data-services) for the C# programming language.

The client relies heavily on the following dependencies:

 * Newtonsoft.Json (for JSON serialization and deserialization)
 * Swagger codegen (for model class generation from Swagger files)

## Usage

Here is a simple code snippet demonstrating how to use the client package:

```
using Quadient.DataServices.Api;

...

var credentials = new Credentials(US, "company", "username", "password");
var client = new Client(credentials);

response = await client.execute(new AddressCorrection(...));
```

Check out the `DataServicesExample project` folder for more comprehensive examples.