using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempuratureConversions
    {
        public static double FahrenheitToCelsius(double Fahrenheit) {
            var celsius = (Fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public static double CelsiusToFahrenheit(double Celsius)
        {
            var fahrenheit = (Celsius*9/5)+32;
            return fahrenheit;
        }
    }
}
