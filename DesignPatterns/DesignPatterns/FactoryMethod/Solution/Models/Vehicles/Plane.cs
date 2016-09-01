using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Models.Parts;

namespace DesignPatterns.FactoryMethod.Solution.Models.Vehicles
{
    public class Plane : Vehicle
    {
        public Plane()
        {
            Parts.Add(new Tyre());
            Parts.Add(new Tyre());
            Parts.Add(new Engine());
            Parts.Add(new Wing());
        }
    }
}
