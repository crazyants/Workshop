using System;
using Microsoft.Owin.Hosting;

namespace Divergent.Customers.API
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:20186"))
            {
                Console.WriteLine("Dicergent.Customers.API web server is running.");
                Console.WriteLine("Press <enter> to quit.");
                Console.ReadLine();
            }
        }
    }
}
