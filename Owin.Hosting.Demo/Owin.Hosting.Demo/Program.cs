﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Hosting.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine("Listening On Port:12345");
                Console.WriteLine("Please enter to stop");
                Console.ReadLine();
            }

        }
    }
}
