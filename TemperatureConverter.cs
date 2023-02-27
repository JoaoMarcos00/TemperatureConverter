using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine("Enter a temperature value: ");
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit of the temperature (C/F): ");
            char unit = char.Parse(Console.ReadLine());

            double convertedTemp = 0;

            switch (unit)
            {
                case 'C':
                    convertedTemp = (9.0 / 5.0) * temp + 32;
                    Console.WriteLine(temp + " degrees Celsius is " + convertedTemp + " degrees Fahrenheit.");
                    break;
                case 'F':
                    convertedTemp = (5.0 / 9.0) * (temp - 32);
                    Console.WriteLine(temp + " degrees Fahrenheit is " + convertedTemp + " degrees Celsius.");
                    break;
                default:
                    Console.WriteLine("Invalid unit!");
                    break;
            }
        }
    }
}
