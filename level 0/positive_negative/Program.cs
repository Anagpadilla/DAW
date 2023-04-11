using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_negative
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (num < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
        }
    }
}
