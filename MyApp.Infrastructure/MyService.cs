using MyApp.Core.Interfaces;
using System;

namespace MyApp.Infrastructure
{
    public class MyService : IService
    {
        private readonly IWriter writer;

        public MyService(IWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Greet()
        {
            writer.Write("hello world");
        }
    }
}
