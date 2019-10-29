using Nancy;
using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_meet_with_nancy_framework.config
{
    class NancyConfig
    {
        private NancyHost nancy;

        public NancyConfig()
        {
            var url = new Uri("http://localhost:8080");
            var hostConfig = new HostConfiguration { UrlReservations = { CreateAutomatically = true } };
            nancy = new NancyHost(url, new DefaultNancyBootstrapper(), hostConfig);
        }

        public void startServer()
        {
            nancy.Start();
            Console.WriteLine("Server is started successfully.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Server is shutdown.");
            nancy.Stop();
            Console.ReadKey();
        }
    }
}
