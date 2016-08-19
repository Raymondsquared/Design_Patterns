using System;
using DesignPatterns.Strategy.Problem.Abstractions;

namespace DesignPatterns.Strategy.Problem.Model
{
    public class Duck : Animal
    {
        public Duck(){}

        public override void Display()
        {
            Console.WriteLine("Display Duck.");
        }

        public override string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
