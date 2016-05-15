namespace OWIN_Self_Host_With_Dependency
{
    using API;
    using Microsoft.Owin.Hosting;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Server listening on {0}", baseAddress);
                Console.WriteLine(ApiInfo.Help);
                Console.WriteLine("Press [ENTER] to end");
                Console.ReadLine();
            }
        }
    }
}
