using System;
using DesignPatterns.Abstractions;
using DesignPatterns.Strategy.Solution.Model;

namespace DesignPatterns.Strategy.Solution
{
    public class StrategyDesignPattern : IDesignPattern
    {
        public StrategyDesignPattern()
        {
            
        }

        public CONSTANTS.DESIGN_PATTERN_TYPE Type()
        {
            return CONSTANTS.DESIGN_PATTERN_TYPE.STRATEGY;
        }

        public void Run()
        {
            var bird = new Bird();
            var cat = new Cat();
            var dog  = new Dog();
            var duck = new Duck();

            Console.WriteLine($"can bird fly ? : {bird.Fly()}");
            Console.WriteLine($"can cat fly ? : {cat.Fly()}");
            Console.WriteLine($"can dog fly ? : {dog.Fly()}");
            Console.WriteLine($"can duck fly ? : {duck.Fly()}");
        }
    }
}
