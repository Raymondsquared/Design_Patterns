using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Model.Parts;

namespace DesignPatterns.FactoryMethod.Solution.Model.Vehicles
{
    public class Boat : Vehicle
    {
        public Boat()
        {
            Parts.Add(new Engine());
        }
    }
}
