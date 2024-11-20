namespace fullStackOops.Encapsulations
{
    public class BankAccount
    {
        private double balance; // private field

        //public method to deposit

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                balance += amount;
            }
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
