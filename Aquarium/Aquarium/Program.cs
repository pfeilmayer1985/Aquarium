using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Aquarium Length (x) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Aquarium Height (y) : ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            Aquarium.AquariumLeer(x, y);

            Console.ReadLine();

        }
    }
}
