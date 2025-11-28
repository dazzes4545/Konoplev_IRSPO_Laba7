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
            //BankAccount account = new BankAccount("1234567890");

            //account.Deposit(1000);

            //account.Withdraw(1500);

            //account.PrintBalance();

            //zad3
            Car car = new Car("Tesla Model S", 250);

            car.Accelerate(120);

            car.Brake();
        }
    }
}
