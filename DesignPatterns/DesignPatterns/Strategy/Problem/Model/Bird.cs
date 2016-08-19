using System;
using DesignPatterns.Strategy.Problem.Abstractions;

namespace DesignPatterns.Strategy.Problem.Model
{
    public class Bird : Animal
    {
        public Bird(){}

        public override void Display()
        {
            Console.WriteLine("Display Bird.");
        }

        public override string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
