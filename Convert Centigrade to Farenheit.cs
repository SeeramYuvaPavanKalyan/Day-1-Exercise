using System;

namespace Tempature
{
    class Program
    {
        private static void Main(string[] args)
        {
            double Centigrade;
            double Fahrenheit;
            Console.Write("Enter temperature in Centigrade : ");
            Centigrade = Convert.ToInt32(Console.ReadLine());

            Fahrenheit = (double)((Centigrade * 1.8) + 32);
            Console.WriteLine("Temperature in Fahrenheit is : " + Fahrenheit);
        }
    }
}