using System;
using DesignPatterns.Facade.Solutions.Models;

namespace DesignPatterns.Facade.Solutions.SubSystems
{
    public class Savings
    {
        public bool HasSufficientSavings(Customer c, double amount)
        {
            return (new Random().Next(0, 100) > 20);
        }
    }
}
