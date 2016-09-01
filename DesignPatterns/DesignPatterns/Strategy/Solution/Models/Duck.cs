using System;
using DesignPatterns.Strategy.Solution.Abstractions;
using DesignPatterns.Strategy.Solution.Implementations;

namespace DesignPatterns.Strategy.Solution.Models
{
    public class Duck : Animal
    {
        public Duck()
        {
            _flyStrategy = new SimpleFlyStrategy();
        }

        public override void Display()
        {
            Console.WriteLine("Display Duck.");
        }
    }
}
