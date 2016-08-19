using System;
using DesignPatterns.Strategy.Problem.Abstractions;

namespace DesignPatterns.Strategy.Problem.Model
{
    public class Dog : Animal
    {
        public Dog(){}

        public override void Display()
        {
            Console.WriteLine("Display Dog.");
        }

        public override string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
