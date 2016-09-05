using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Abstractions;
using DesignPatterns.Command.Solution;
using DesignPatterns.Facade.Solutions;
using DesignPatterns.FactoryMethod.Solution;
using DesignPatterns.Strategy.Solution;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var patterns = GetDesignPatterns();

            while (true)
            {

                var collections = new List<IDesignPattern>();

                Console.WriteLine("\nPlease make your selection or just press enter to run everything : ");

                for (var x = 0; x < patterns.Count; x++)
                {
                    Console.WriteLine($"{x+1}. {patterns[x].Type()}");
                }

                Console.WriteLine("\n===================================================================");
                Console.Write("\nEnter Input : ");

                string input = Console.ReadLine();

                //EXIT
                if (string.Equals(input, "exit", StringComparison.InvariantCultureIgnoreCase)) break;

                //ALL
                if (string.IsNullOrEmpty(input)) collections = patterns.ToList();

                //ELSE
                int numberInput;
                Int32.TryParse(input, out numberInput);

                if (numberInput > 0 && numberInput <= patterns.Count)
                {
                    collections.Add(patterns[numberInput-1]);
                    Run(collections);
                }
                else Console.WriteLine("\nInvalid Input! Please try again ... ");
            }                 
        }

        public static IList<IDesignPattern> GetDesignPatterns()
        {
            IList<IDesignPattern> dessignPatterns = new List<IDesignPattern>();
            dessignPatterns.Add(new StrategyDesignPattern());
            dessignPatterns.Add(new FactoryMethodDesignPattern());
            dessignPatterns.Add(new CommandDesignPattern());
            dessignPatterns.Add(new FacadeDesignPattern());

            return dessignPatterns;
        }

        public static void Run(IList<IDesignPattern> inputCollection)
        {
            foreach (var dessignPattern in inputCollection)
            {
                Console.WriteLine($"Design Pattern Type : {dessignPattern.GetType().Name}");

                Console.WriteLine($"{Environment.NewLine}");
                dessignPattern.Run();                
                Console.WriteLine($"{Environment.NewLine}");
                Console.WriteLine($"---------------------------------------------------------------------");
                Console.WriteLine($"{Environment.NewLine}");
            }
        }
    }
}
