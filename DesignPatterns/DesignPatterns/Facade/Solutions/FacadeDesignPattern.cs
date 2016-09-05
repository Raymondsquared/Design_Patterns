using System;
using System.Collections.Generic;
using System.Threading;
using DesignPatterns.Abstractions;
using DesignPatterns.Facade.Solutions.Implementations;
using DesignPatterns.Facade.Solutions.Models;

namespace DesignPatterns.Facade.Solutions
{
    public class FacadeDesignPattern : IDesignPattern
    {
        public FacadeDesignPattern()
        {
            
        }

        public CONSTANTS.DESIGN_PATTERN_TYPE Type()
        {
            return CONSTANTS.DESIGN_PATTERN_TYPE.FACADE;
        }

        public void Run()
        {
            var bankFacade = new BankFacade();

            var customers = new List<Customer>()
            {
                new Customer() {Name = "Frank Lampard"},
                new Customer() { Name = "Steven Gerrard" },
                new Customer() { Name = "Raymond Boles" },
                new Customer() { Name = "First Last" },
                new Customer() { Name = "Random ABC" },
            };

            foreach (var customer in customers)
            {
                Thread.Sleep(1000);
                var random = new Random().Next(100000, 20000000);
                var isEligible = bankFacade.IsEligibleForMortgage(customer, random);
                Console.WriteLine(customer.Name + " has been " + (isEligible ? "Approved" : "Rejected") + "\n");
            }
        }
    }
}
