using System;
using CodeGeneration;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37;
            double fahrenheit = 98.6;

            Console.WriteLine("Value of {0} celcius to fahrenheit is {1}", celcius, Converter.ToFahrenheit((celcius)));

            Console.WriteLine("Value of {0} celcius to fahrenheit is {1}", fahrenheit, Converter.Tocelcious((fahrenheit)));

            Console.ReadLine();

          
        }
    }
}
