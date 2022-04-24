using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ TempuratureConversions.FahrenheitToCelsius(100)}");
            Console.WriteLine($"{ TempuratureConversions.CelsiusToFahrenheit(37.77777777777778)}");
        }
    }
}