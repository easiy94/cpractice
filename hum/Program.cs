using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humansOwn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            human human = new human("Béla", "Kovács", 1977);
            Console.WriteLine($"A személy neve: {human.name}");
            Console.ReadKey();
        }
    }
}
