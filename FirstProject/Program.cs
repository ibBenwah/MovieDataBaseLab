// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace CLasses
{
    public class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
        }

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;
            this.Balance = initalBalance;
        }
    }   
}