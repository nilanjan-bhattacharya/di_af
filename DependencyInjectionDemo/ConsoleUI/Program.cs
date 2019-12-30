using Autofac;
using System;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure(); //Instantiate DI container.

            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();

            Console.ReadLine();
        }
    }
}
