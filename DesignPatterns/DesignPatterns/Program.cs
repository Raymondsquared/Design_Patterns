using System;
using System.Collections.Generic;
using DesignPatterns.Abstractions;
using DesignPatterns.Strategy.Solution;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run(GetDesignPatterns());
        }

        public static IList<IDesignPattern> GetDesignPatterns()
        {
            IList<IDesignPattern> dessignPatterns = new List<IDesignPattern>();
            dessignPatterns.Add(new StrategyDesignPattern());

            return dessignPatterns;
        }

        public static void Run(IList<IDesignPattern> inputCollection)
        {
            foreach (var dessignPattern in inputCollection)
            {
                Console.WriteLine($"Design Pattern Type : {dessignPattern.GetType()}");

                Console.WriteLine($"{Environment.NewLine}");
                dessignPattern.Run();                
                Console.WriteLine($"{Environment.NewLine}");
                Console.WriteLine($"---------------------------------------------------------------------");
                Console.WriteLine($"{Environment.NewLine}");
            }
        }
    }
}
