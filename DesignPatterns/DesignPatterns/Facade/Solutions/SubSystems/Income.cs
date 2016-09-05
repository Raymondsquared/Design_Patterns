using System;
using DesignPatterns.Facade.Solutions.Models;

namespace DesignPatterns.Facade.Solutions.SubSystems
{
    public class Income
    {
        public bool HasEnoughIncome(Customer c)
        {
            return (new Random().Next(0, 100) > 30);
        }
    }
}
