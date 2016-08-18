using DesignPatterns.Strategy.Solution.Abstractions;

namespace DesignPatterns.Strategy.Solution.Implementations
{
    public class HighFlyStrategycs : IFlyStrategy
    {
        public string Fly()
        {
            return "Fly High!";
        }
    }
}
