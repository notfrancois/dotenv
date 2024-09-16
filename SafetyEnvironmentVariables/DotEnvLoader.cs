namespace SafetyEnvironmentVariables;

public static class DotEnvLoader
{
    /// <summary>
    /// Bootstrap the environment variables from a .env file.
    /// </summary>
    public static void Bootstrap()
    {
        var root = Directory.GetCurrentDirectory();
        var dotenv = Path.Combine(root, ".env");
        
        if(!File.Exists(dotenv))
            return;
        
        var lines = File.ReadAllLines(dotenv);
        foreach (var line in lines)
        {
            var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);
            
            if (parts.Length != 2)
                continue;
            
            var key = parts[0];
            var value = parts[1];
            
            Environment.SetEnvironmentVariable(key, value);
        }
    }
}