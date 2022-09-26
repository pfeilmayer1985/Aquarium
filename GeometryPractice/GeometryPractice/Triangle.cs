using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    public class Triangle : Geometry
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Length3 { get; set; }

        public Triangle(double length1, double length2, double length3)
        {
            Length1 = length1;
            Length2 = length2;
            Length3 = length3;
            GeometryName = "Triangle";
            
            Perimeter = Length1 + Length2 + Length3;
            double semiperimeter = Perimeter / 2;
            double areaform = semiperimeter*(semiperimeter-Length1)*(semiperimeter-Length2)*(semiperimeter-Length3);
            Area = Math.Sqrt(areaform);

        }

        public static Triangle MakeNewTriangle()
        {
            Console.Clear();
            Console.WriteLine($"You are drawing now a Triangle.");
            Console.WriteLine("Enter triangle side length 1 of 3 :");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter triangle side length 2 of 3 :");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter triangle side length 3 of 3 :");
            double length3 = Convert.ToDouble(Console.ReadLine());
            Triangle newUserTriangle = new Triangle(length1, length2, length3);
            Console.WriteLine($"Triangle Area is : {newUserTriangle.GeneralArea()}");
            Console.WriteLine($"Triangle Perimeter is : {newUserTriangle.GeneralPerimeter()}");
            Console.WriteLine("To continue, press <ENTER>");
            Console.ReadLine();
            return newUserTriangle;
        }
    }
}
