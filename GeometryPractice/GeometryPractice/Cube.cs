using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    public class Cube : Geometry
    {
        public double SideLength { get; set; }

        public Cube(double sideLength)
        {
            SideLength = sideLength;
            GeometryName = "Cube";
            Area = 6 * (SideLength * SideLength);
            Perimeter = 12 * SideLength;

        }

        public static Cube MakeNewCube()
        {
            Console.Clear();
            Console.WriteLine($"You are drawing now a Cube.");
            Console.WriteLine("Enter cube side length :");
            double lengthCube = Convert.ToDouble(Console.ReadLine());
            Cube newUserCube = new Cube(lengthCube);
            Console.WriteLine($"Cube Area is : {newUserCube.GeneralArea()}");
            Console.WriteLine($"Cube Perimeter is : {newUserCube.GeneralPerimeter()}");
            Console.WriteLine("To continue, press <ENTER>");
            Console.ReadLine();
            return newUserCube;

        }
    }
}
