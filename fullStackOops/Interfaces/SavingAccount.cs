using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Interfaces
{
    public class SavingAccount : IBankAccount, IManageBank
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public void closeAccount()
        {
            Console.WriteLine("Close Saving Account");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public void openAccount()
        {
            Console.WriteLine("Open Saving Account");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw in Saving Account");
        }
    }
    
}
