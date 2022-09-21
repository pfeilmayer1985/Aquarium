using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Your Aquarium Length (x) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Aquarium Height (y) : ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            Aquarium.AquariumLeer(x, y);
            */

            Console.WriteLine(CarUebung.AskForCar());
            CarUebung.ShowMyCar();
            
            Console.ReadLine();

            

        }
       
    }
}
