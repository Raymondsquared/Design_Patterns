namespace DesignPatterns.FactoryMethod.Solution.Abstractions
{
    public abstract class Part
    {
        public string Name => GetType().Name;
    }
}
