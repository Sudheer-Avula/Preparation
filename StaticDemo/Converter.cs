using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
   public static class Converter
    {


        

        public static double ToFahrenheit(double celicus)
        {
            return (celicus * 9 / 5) + 32;
        }

        public static double Tocelcious(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    
}
