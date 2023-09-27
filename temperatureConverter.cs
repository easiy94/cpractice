using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valasz;
            double farenheit, celsius;
            int temp;
            Console.WriteLine("Hőmérséklet átváltás");
            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Add meg MIBE akarod átváltani a hőmérsékletet\n C - Celsius\n  F - Farenheit\n");
            Console.WriteLine("Válasz: ");
            valasz = Console.ReadLine();

            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Add meg a hőmérsékletet: ");
            temp = Convert.ToInt32(Console.ReadLine());

            if (valasz == "C") 
            {
                celsius = (temp -32)/1.800;
                celsius.ToString();
                Console.WriteLine($"A hőmérséklet Celsiusban: {celsius}");
            }
            else if (valasz == "F") 
            {
                farenheit = temp * 1.800 + 32;
                farenheit.ToString();
                Console.WriteLine($"A hőmérséklet Fahrenheitben: {farenheit}");
            }

            else
            {
                Console.WriteLine("Elbasztad a betüt vagy fogyaték vagy, kezd előlről");
            }
            

            Console.ReadKey();
        }
    }
}
