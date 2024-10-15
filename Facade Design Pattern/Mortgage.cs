using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Facade.NetOptimized.Program;

namespace Facade_Design_Pattern
{
    public class Mortgage
    {
        private readonly Bank bank = new();
        private readonly Loan loan = new();
        private readonly Credit credit = new();
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);
            bool eligible = true;
            // Check creditworthyness of applicant
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }

}
