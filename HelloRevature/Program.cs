using System;

namespace HelloRevature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Account a = new Account();
            a.Withdraw(5);
        }
    }
    class Account
{
    decimal balance;
    private readonly object sync = new object();
    public void Withdraw(decimal amount) 
    {
        lock (sync) 
        {
            if (amount > balance) 
            {
                throw new Exception(
                    "Insufficient funds");
            }
            balance -= amount;
        }
    }
}
}
