using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Abstract
{
    public class SavingAccount : BankAccount
    {
        public override void Balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public override void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdraw in Saving Account");
        }
    }
}
