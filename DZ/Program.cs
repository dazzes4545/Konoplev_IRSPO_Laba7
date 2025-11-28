namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.PrintInfo();

            Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            book2.PrintInfo();
        }
    }
}
