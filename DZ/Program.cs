namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            //Book book1 = new Book();
            //book1.PrintInfo();

            //Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            //book2.PrintInfo();

            //zad2
            BankAccount account = new BankAccount("1234567890");

            account.Deposit(1000);

            account.Withdraw(500);

            account.PrintBalance();
        }
    }
}
