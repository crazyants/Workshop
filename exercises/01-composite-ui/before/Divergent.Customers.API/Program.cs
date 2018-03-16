using System;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Divergent.Customers.API
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var tcs = new TaskCompletionSource<object>();
            Console.CancelKeyPress += (sender, e) => { tcs.SetResult(null); };

            using (WebApp.Start<Startup>("http://localhost:20186"))
            {
                await Console.Out.WriteLineAsync("Divergent.Customers.API web server is running.");
                await Console.Out.WriteLineAsync("Press Ctrl+C to exit...");

                await tcs.Task;
            }
        }
    }
}
