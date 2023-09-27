using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace higherLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Több vagy kevesebb?\n");
            Console.Write("----------------------------------------------\n");

            Random random = new Random();
            int randomnumber = random.Next(0, 10);
            int choice=0, valasz, proba=3;
            Console.WriteLine("Gondoltam egy számra 0 és 10 között");
            Console.WriteLine("3 próbálkozásból találd ki hogy melyik az a szám!");
            //Console.WriteLine(randomnumber);
            while (choice < 3)
            {
                Console.WriteLine("Mi az a szám? :");
                valasz = Convert.ToInt32(Console.ReadLine());
                if (valasz == randomnumber)
                {
                    Console.WriteLine("Eltaláltad! Gratulálok!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Nem erre a számra gondoltam {proba - 1} próbálkozásod maradt");
                    choice++;
                }
            }
            
            Console.ReadKey();
        }
    }
}
