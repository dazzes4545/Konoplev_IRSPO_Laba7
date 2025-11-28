using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public bool IsAvailable;

        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестен";
            Year = 0;
            IsAvailable = false;
        }

        public Book(string title, string author, int year, bool isAvailable)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }

        public void PrintInfo()
        {
            string availableText;
            if (IsAvailable)
            {
                availableText = "Да";
            }
            else
            {
                availableText = "Нет";
            }
            Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {availableText}");
        }
    }

}
