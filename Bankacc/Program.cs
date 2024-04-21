namespace Bankacc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;

            account.Deposit(15);
            account.WithDraw(8);
            account.Print();
        }
    }
}
