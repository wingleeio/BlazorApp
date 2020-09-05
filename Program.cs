using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorState;
using System.Reflection;
using MediatR;

namespace BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") });

            ConfigureServices(builder.Services);
            
            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection aServiceCollection)
        {
            aServiceCollection.AddBlazorState
            (
                (aOptions) =>
                {
                aOptions.UseReduxDevToolsBehavior = true;
                aOptions.Assemblies =
                    new Assembly[]
                    {
                    typeof(Program).GetTypeInfo().Assembly,
                    };
                }
            );
        }
    }
}
