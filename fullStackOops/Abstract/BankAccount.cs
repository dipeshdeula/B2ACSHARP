namespace fullStackOops.Abstract
{
    public abstract class BankAccount
    {
        public void GetMessage()
        {
            Console.WriteLine("Welcome to the Kumari Bank");
        }

        //abstract method with no body
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void Balance();
    }
}
