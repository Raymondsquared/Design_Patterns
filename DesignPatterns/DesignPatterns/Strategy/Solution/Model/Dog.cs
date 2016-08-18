using System;
using DesignPatterns.Strategy.Solution.Abstractions;
using DesignPatterns.Strategy.Solution.Implementations;

namespace DesignPatterns.Strategy.Solution.Model
{
    public class Dog : Animal
    {
        public Dog()
        {
            _flyStrategy = new CantFlyStrategy();
        }

        public override void Display()
        {
            Console.WriteLine("Display Dog.");
        }
    }
}
