using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.CLI
{
    class MyApplication : IApplication
    {
        private readonly IService service;

        public MyApplication(IService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public void Run()
        {
            service.Greet();
        }
    }
}
