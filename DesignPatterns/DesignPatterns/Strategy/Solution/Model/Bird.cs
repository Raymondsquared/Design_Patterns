using System;
using DesignPatterns.Strategy.Solution.Abstractions;
using DesignPatterns.Strategy.Solution.Implementations;

namespace DesignPatterns.Strategy.Solution.Model
{
    public class Bird : Animal
    {
        public Bird()
        {
            _flyStrategy = new HighFlyStrategycs();
        }

        public override void Display()
        {
            Console.WriteLine("Display Bird.");
        }
    }
}
