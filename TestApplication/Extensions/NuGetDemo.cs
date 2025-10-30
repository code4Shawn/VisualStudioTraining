// Exercise 10: NuGet Package Manager
// Practice: Installing and using NuGet packages

namespace TestApplication.Extensions
{
    // This class demonstrates NuGet package usage
    // TASKS:
    // 1. Open Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
    // 2. Install packages using: Install-Package [PackageName]
    // 3. Use NuGet GUI (Right-click project > Manage NuGet Packages)
    // 4. Update packages
    // 5. Remove packages
    
    // COMMON PACKAGES TO INSTALL:
    // Install-Package Newtonsoft.Json
    // Install-Package Serilog
    // Install-Package Serilog.Sinks.Console
    // Install-Package Dapper
    // Install-Package AutoMapper
    
    // EXAMPLE: Using Newtonsoft.Json (after installing)
    // Uncomment after installing: Install-Package Newtonsoft.Json
    /*
    using Newtonsoft.Json;
    
    public class JsonDemo
    {
        public void SerializeObject()
        {
            var person = new { Name = "John", Age = 30 };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine(json);
        }
        
        public void DeserializeObject()
        {
            string json = "{\"Name\":\"John\",\"Age\":30}";
            var person = JsonConvert.DeserializeObject<dynamic>(json);
            Console.WriteLine($"{person.Name} is {person.Age} years old");
        }
    }
    */
    
    // EXAMPLE: Using Serilog (after installing)
    // Uncomment after installing: Install-Package Serilog, Install-Package Serilog.Sinks.Console
    /*
    using Serilog;
    
    public class LoggingDemo
    {
        public void SetupLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            
            Log.Information("Application started");
            Log.Warning("This is a warning");
            Log.Error("This is an error");
        }
    }
    */
    
    public class NuGetDemo
    {
        // TASK: Install Newtonsoft.Json and use it here
        public void UseJsonPackage()
        {
            // After installing Newtonsoft.Json:
            // 1. Add using Newtonsoft.Json;
            // 2. Use JsonConvert.SerializeObject()
            
            Console.WriteLine("Install Newtonsoft.Json to use JSON serialization");
        }

        // TASK: Install Serilog and use it here
        public void UseLoggingPackage()
        {
            // After installing Serilog:
            // 1. Add using Serilog;
            // 2. Configure logger
            // 3. Use Log.Information(), Log.Warning(), etc.
            
            Console.WriteLine("Install Serilog for structured logging");
        }

        // TASK: Install AutoMapper and use it here
        public void UseAutoMapper()
        {
            // After installing AutoMapper:
            // 1. Add using AutoMapper;
            // 2. Configure mappings
            // 3. Use mapper.Map<T>()
            
            Console.WriteLine("Install AutoMapper for object mapping");
        }
    }

    // NUGET PACKAGE MANAGER CONSOLE COMMANDS:
    // 
    // Install a package:
    //   Install-Package [PackageName]
    //   Install-Package Newtonsoft.Json
    //
    // Install specific version:
    //   Install-Package [PackageName] -Version [VersionNumber]
    //   Install-Package Newtonsoft.Json -Version 13.0.1
    //
    // Update a package:
    //   Update-Package [PackageName]
    //   Update-Package Newtonsoft.Json
    //
    // Update all packages:
    //   Update-Package
    //
    // Uninstall a package:
    //   Uninstall-Package [PackageName]
    //   Uninstall-Package Newtonsoft.Json
    //
    // List installed packages:
    //   Get-Package
    //
    // Search for packages:
    //   Find-Package [SearchTerm]
    //   Find-Package Json
    //
    // Get package details:
    //   Get-Package [PackageName]
    //   Get-Package Newtonsoft.Json

    // NUGET GUI WORKFLOW:
    // 1. Right-click project > Manage NuGet Packages
    // 2. Browse tab: Search and install new packages
    // 3. Installed tab: View and manage installed packages
    // 4. Updates tab: See available updates
    // 5. Filter by: Stable, Prerelease, All
    // 6. Sort by: Relevance, Downloads, etc.

    // PRACTICE EXERCISES:
    public class NuGetPractice
    {
        // Exercise 1: Install and use Newtonsoft.Json
        public void Exercise1_Json()
        {
            // 1. Install-Package Newtonsoft.Json
            // 2. Serialize an object to JSON
            // 3. Deserialize JSON to object
        }

        // Exercise 2: Install and use Serilog
        public void Exercise2_Logging()
        {
            // 1. Install-Package Serilog
            // 2. Install-Package Serilog.Sinks.Console
            // 3. Configure logger
            // 4. Log messages at different levels
        }

        // Exercise 3: Install and use Dapper (micro ORM)
        public void Exercise3_DataAccess()
        {
            // 1. Install-Package Dapper
            // 2. Use with SQL connection
            // 3. Execute queries
        }

        // Exercise 4: Install and use FluentValidation
        public void Exercise4_Validation()
        {
            // 1. Install-Package FluentValidation
            // 2. Create validator classes
            // 3. Validate objects
        }

        // Exercise 5: Install and use xUnit (testing framework)
        public void Exercise5_Testing()
        {
            // 1. Install-Package xunit
            // 2. Install-Package xunit.runner.visualstudio
            // 3. Write unit tests
        }
    }

    // TIPS:
    // - Always check package popularity and last update date
    // - Read package documentation before installing
    // - Be cautious with prerelease packages in production
    // - Keep packages updated for security patches
    // - Use specific versions for reproducible builds
    // - Review package dependencies before installing
    // - Use .csproj file to see all package references
}
