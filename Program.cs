
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddCommandLine(args)
            .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseConfiguration(config)
                .Build();
            host.Run();
        }

        // public static void Main(string[] args)
        // {
        //     BuildWebHost(args).Run();
        // }

        // public static IWebHost BuildWebHost(string[] args) =>
        //     WebHostBuilder.crCreateDefaultBuilder(args)
        //         .UseStartup<Startup>()
        //         .Build();
    }
}