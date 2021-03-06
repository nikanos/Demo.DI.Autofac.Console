﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {

                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
