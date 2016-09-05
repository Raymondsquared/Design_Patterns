using System;
using DesignPatterns.Facade.Solutions.Models;

namespace DesignPatterns.Facade.Solutions.SubSystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            return (new Random().Next(0, 100) > 50);
        }
    }
}
