using DesignPatterns.Strategy.Solution.Abstractions;

namespace DesignPatterns.Strategy.Solution.Implementations
{
    public class CantFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "Can't Fly!";
        }
    }
}
