using System;
using DesignPatterns.Facade.Solutions.Models;
using DesignPatterns.Facade.Solutions.SubSystems;

namespace DesignPatterns.Facade.Solutions.Implementations
{
    public class BankFacade
    {
        private readonly Savings _bank;
        private readonly Income _income;
        private readonly Loan _loan;
        private readonly Credit _credit;

        public BankFacade()
        {
            _bank = new Savings();
            _income = new Income();
            _loan = new Loan();
            _credit = new Credit();
        }

        public bool IsEligibleForMortgage(Customer cust, double amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan", cust.Name, amount);

            var isEligible = true;

            //need to have at least 20% deposit
            if (!_bank.HasSufficientSavings(cust, amount * 0.2))
            {
                isEligible = false;
                Console.WriteLine($"{cust.Name} has insufficient savings");
            }
            else if (!_income.HasEnoughIncome(cust))
            {
                isEligible = false;
                Console.WriteLine($"{cust.Name} doesn't have enough income");
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                isEligible = false;
                Console.WriteLine($"{cust.Name} has bad loan in the past");
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                isEligible = false;
                Console.WriteLine($"{cust.Name} doesn't have good credit score");
            }

            return isEligible;
        }
    }
}
