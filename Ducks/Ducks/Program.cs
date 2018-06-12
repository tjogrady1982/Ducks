using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quacker = new Duck("Quackers","Eider", 100, 12);
            var quackers = new Duck("Orange", "Mallard", 101, 17);

            if (quack.Equals(quackers))//weight comparer
            {
                Console.WriteLine("a match!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("no match!");
                Console.ReadLine();
            }
        }
    }
}
