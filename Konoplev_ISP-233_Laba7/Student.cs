using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Konoplev_ISP_233_Laba7
{
    internal class Student
    {
        

        public string name;
        public int age;
        public string group;

        public Student()
                {
            Console.WriteLine();
                }

        public Student(string uName, int uAge)
        {
            name = uName;
            age = uAge;
            group = "хз";
        }

        public Student(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
        }

        public void PrintInfo()
            {
                Console.WriteLine($"Name: {name}, Age: {age}, Group: {group}");
            }
    }
}

