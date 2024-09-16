using Microsoft.Extensions.Hosting;

namespace SafetyEnvironmentVariables;

public static partial class Extensions
{
    /// <summary>
    /// Load all environment variables from an .env file if it exists and pull vars from system environment.
    /// </summary>
    public static IHostApplicationBuilder WithEnvironmentVariables(this IHostApplicationBuilder builder)
    {
        DotEnvLoader.Bootstrap();
        
        return builder;
    }
}