using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Practice4_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var formChooseEmployee = serviceProvider.GetRequiredService<FormChooseEmployee>();
                Application.Run(formChooseEmployee);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<FormChooseEmployee>().AddLogging(configure => configure.AddConsole());
        }
    }
}