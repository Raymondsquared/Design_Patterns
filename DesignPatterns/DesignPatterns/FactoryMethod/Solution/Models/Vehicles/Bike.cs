using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Models.Parts;

namespace DesignPatterns.FactoryMethod.Solution.Models.Vehicles
{
    public class Bike : Vehicle
    {
        public Bike()
        {
            Parts.Add(new Tyre());
            Parts.Add(new Tyre());
            Parts.Add(new Engine());
        }
    }
}
