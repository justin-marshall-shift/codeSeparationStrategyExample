using System;
using CoreExampleNuGet;

namespace CustomizedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new NameGenerator();

            Console.WriteLine($"Hello World says hello to {generator.GetName()}!");
        }
    }
}
