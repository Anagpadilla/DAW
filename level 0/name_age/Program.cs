using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.Write("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

        }
    }
}
