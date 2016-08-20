namespace DesignPatterns.Abstractions
{
    public interface IDesignPattern
    {
        CONSTANTS.DESIGN_PATTERN_TYPE Type();
        void Run();
    }
}
