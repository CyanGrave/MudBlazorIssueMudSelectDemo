using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace BlazorTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //CreateHostBuilder().Build().RunAsync();
            Application.Run(new Form1());

        }

        static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
                services.AddBlazorWebView());


    }
}