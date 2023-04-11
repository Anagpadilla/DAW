using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degrees_celsius
{
    class Program
    {   // prompt the user to enter degrees Celsius
        Console.Write("Enter degrees Celsius: ");
        
        // read the input as a double
        double degreesCelsius = double.Parse(Console.ReadLine());

        // calculate the equivalent in Fahrenheit
        double degreesFahrenheit = (degreesCelsius * 1.8) + 32;

        // display the result
        Console.WriteLine("The equivalent in Fahrenheit is: " + degreesFahrenheit);
    }
}
