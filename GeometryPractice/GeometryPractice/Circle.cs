using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            GeometryName = "Circle";
            Radius = radius;
            Area = Math.PI * (Radius * Radius);
            Perimeter = 2 * Math.PI * Radius;
        }

        public static Circle MakeNewCircle()
        {
            Console.Clear();
            Console.WriteLine($"You are drawing now a Circle.");
            Console.WriteLine("Enter circle radius :");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle newUserCircle = new Circle(radius);
            Console.WriteLine($"Circle Area is : {newUserCircle.GeneralArea()}");
            Console.WriteLine($"Circle Perimeter is : {newUserCircle.GeneralPerimeter()}");
            Console.WriteLine("To continue, press <ENTER>");
            Console.ReadLine();
            return newUserCircle;
        }


    }
}
