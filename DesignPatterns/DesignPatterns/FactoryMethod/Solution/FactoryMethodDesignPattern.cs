using System;
using DesignPatterns.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Implementations;
using DesignPatterns.Strategy.Solution.Model;

namespace DesignPatterns.FactoryMethod.Solution
{
    public class FactoryMethodDesignPattern : IDesignPattern
    {
        public FactoryMethodDesignPattern()
        {
            
        }

        public CONSTANTS.DESIGN_PATTERN_TYPE Type()
        {
            return CONSTANTS.DESIGN_PATTERN_TYPE.FACTORY_METHOD;
        }

        public void Run()
        {
            var car = VehicleFactory.Create(CONSTANTS.VEHICLES.CAR);
            var bike = VehicleFactory.Create(CONSTANTS.VEHICLES.BIKE);
            var boat = VehicleFactory.Create(CONSTANTS.VEHICLES.BOAT);
            var plane = VehicleFactory.Create(CONSTANTS.VEHICLES.PLANE);            

            Console.WriteLine($"car spec : {car.Print()}");
            Console.WriteLine($"bike spec : {bike.Print()}");
            Console.WriteLine($"boat spec : {boat.Print()}");
            Console.WriteLine($"plane spec : {plane.Print()}");
        }
    }
}
