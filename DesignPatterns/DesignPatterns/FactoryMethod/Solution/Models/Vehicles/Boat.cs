using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Models.Parts;

namespace DesignPatterns.FactoryMethod.Solution.Models.Vehicles
{
    public class Boat : Vehicle
    {
        public Boat()
        {
            Parts.Add(new Engine());
        }
    }
}
