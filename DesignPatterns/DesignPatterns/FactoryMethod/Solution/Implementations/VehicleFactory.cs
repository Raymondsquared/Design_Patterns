using DesignPatterns.FactoryMethod.Solution.Abstractions;
using DesignPatterns.FactoryMethod.Solution.Models.Vehicles;

namespace DesignPatterns.FactoryMethod.Solution.Implementations
{
    public class VehicleFactory
    {
        public static Vehicle Create(CONSTANTS.VEHICLES input)
        {
            switch (input)
            {
                case CONSTANTS.VEHICLES.CAR:
                    return new Car();
                case CONSTANTS.VEHICLES.BIKE:
                    return new Bike();
                case CONSTANTS.VEHICLES.BOAT:
                    return new Boat();
                case CONSTANTS.VEHICLES.PLANE:
                    return new Plane();
                default:
                    return null;
            }
        }
    }
}
