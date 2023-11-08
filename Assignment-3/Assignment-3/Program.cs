using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using TryParse to convert a string to an integer
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Successfully converted to integer: {result}");
            }
            else
            {
                Console.WriteLine("Conversion to integer failed. Invalid input.");
            }

            // Using Convert to convert a string to a double
            Console.Write("Enter a double: ");
            string doubleInput = Console.ReadLine();
            try
            {
                double doubleResult = Convert.ToDouble(doubleInput);
                Console.WriteLine($"Successfully converted to double: {doubleResult}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to double failed. Invalid input.");
            }

            // Using Parse to convert a string to a decimal
            Console.Write("Enter a decimal: ");
            string decimalInput = Console.ReadLine();
            try
            {
                decimal decimalResult = decimal.Parse(decimalInput);
                Console.WriteLine($"Successfully converted to decimal: {decimalResult}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to decimal failed. Invalid input.");
            }
        }
    }
}
