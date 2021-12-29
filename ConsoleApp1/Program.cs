using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.Write("Enter the temperature in Fahrenheit degrees (°F) ");
            F = double.Parse(Console.ReadLine());
            C = 5d / 9 * (F - 32);
            Console.WriteLine($"Temperature in Celsius degrees: {C}°C");
            Console.ReadKey();
        }
    }
}
