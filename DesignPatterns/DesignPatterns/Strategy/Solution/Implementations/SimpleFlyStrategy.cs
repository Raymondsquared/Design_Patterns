using DesignPatterns.Strategy.Solution.Abstractions;

namespace DesignPatterns.Strategy.Solution.Implementations
{
    public class SimpleFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "Fly!";
        }
    }
}
