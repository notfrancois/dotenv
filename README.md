# dotenv | A simple .env loader for .NET 8

[![NuGet](https://img.shields.io/nuget/v/PiscesMetadata.EnvironmentVariables.svg)](https://www.nuget.org/packages/PiscesMetadata.EnvironmentVariables/)

## Description

`dotenv` provides simple support for loading environment variables from a `.env` file to the system level for .NET 8 applications. It helps manage sensitive configurations and enhances application portability.

## Features

-   Automatic loading of environment variables from a `.env` file.
-   Compatible with .NET 8.
-   Easy integration into existing projects.

## Installation

To install `dotenv`, add the package to your project using NuGet:

```bash
dotnet add package PiscesMetadata.EnvironmentVariables
```

```csharp
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .WithEnvironmentVariables()
            .ConfigureServices((hostContext, services) =>
            {
                // Configure your services here
            });
}


```

## `.env` File

Create a file named `.env` in the root of your project and define your environment variables in the following format:

```
DATABASE_URL=your_database_url
API_KEY=your_api_key
```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributions

Contributions are welcome. If you would like to contribute, please open an issue or submit a pull request.

## Contact

For more information, contact François López at [here](mailto:francois@piscesmetadata.com).
