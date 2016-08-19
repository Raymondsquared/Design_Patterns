using System;
using DesignPatterns.Strategy.Solution.Abstractions;

namespace DesignPatterns.Strategy.Problem.Abstractions
{
    public abstract class Animal
    {

        protected Animal()
        {
        }        
        
        public abstract void Display();

        public abstract string Fly();        

        public void CommonAttribute()
        {
            Console.WriteLine("They are all animals.");
        }
    }
}
