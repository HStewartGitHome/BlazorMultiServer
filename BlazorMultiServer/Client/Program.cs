using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;



namespace BlazorMultiServer.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            string uriBackup = "https://localhost:5003/";
            string uriMain = builder.HostEnvironment.BaseAddress;

            Console.WriteLine("Main   URI = [" + uriMain + "]");
            Console.WriteLine("Backup URI = [" + uriBackup + "]");


            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(uriMain)});
          //  builder.Services.AddTransient(sp => new BackupHttpClient(uriBackup));

            await builder.Build().RunAsync();
        }
    }
}
