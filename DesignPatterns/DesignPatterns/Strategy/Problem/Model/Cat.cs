using System;
using DesignPatterns.Strategy.Problem.Abstractions;

namespace DesignPatterns.Strategy.Problem.Model
{
    public class Cat : Animal
    {
        public Cat(){}

        public override void Display()
        {
            Console.WriteLine("Display Cat.");
        }

        public override string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
