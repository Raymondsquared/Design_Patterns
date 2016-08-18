using System;

namespace DesignPatterns.Strategy.Solution.Abstractions
{
    public abstract class Animal
    {
        protected IFlyStrategy _flyStrategy;

        protected Animal()
        {
        }        
        
        public abstract void Display();

        public string Fly()
        {
            return _flyStrategy.Fly();
        }

        public void CommonAttribute()
        {
            Console.WriteLine("They are all animals.");
        }
    }
}
