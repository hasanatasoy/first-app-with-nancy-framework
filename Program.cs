using first_meet_with_nancy_framework.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_meet_with_nancy_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            NancyConfig nancy = new NancyConfig();
            nancy.startServer();
        }
    }
}
