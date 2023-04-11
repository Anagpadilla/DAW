using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program that asks the user to enter two numbers,
             multiplies them, and displays the result on the screen*/
            Console.Write("Enter the first number");
            int num1 = int.Parse(Console.Readline());
            Console.Write("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine("The result is: " + result);
        }
    }
}
