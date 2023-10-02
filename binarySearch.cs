using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1, 3, 6, 10, 13, 15, 20, 24, 28, 30};
            int keresettErtek = 20, eleje, vege;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (eleje<=vege)
                {
                    int kozepeAtombnek = (eleje + vege) / 2;
                    if (tomb[kozepeAtombnek]== keresettErtek)
                    {
                        Console.WriteLine(keresettErtek);
                    }
                    if (tomb[kozepeAtombnek]> keresettErtek)
                }
            }

        }
    }
}
