using System;
using DesignPatterns.Facade.Solutions.Models;

namespace DesignPatterns.Facade.Solutions.SubSystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            return (new Random().Next(0, 100) > 40);
        }  
    }
}
