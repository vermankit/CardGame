using Microsoft.Extensions.DependencyInjection;
using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection and configure our services
            IServiceCollection services = new ServiceCollection();

            StartUp startup = new StartUp();
            // Generate a provider
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<CardGameApp>().Start();
        }
    }
}
