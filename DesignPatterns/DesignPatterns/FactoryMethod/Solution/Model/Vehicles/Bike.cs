using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Model.Parts;

namespace DesignPatterns.FactoryMethod.Solution.Model.Vehicles
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
