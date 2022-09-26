using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    public class Square : Geometry
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
            GeometryName = "Square";
            Area = SideLength * SideLength;
            Perimeter = 4 * SideLength;
        }

        public static Square MakeNewSquare()
        {
            Console.Clear();
            Console.WriteLine($"You are drawing now a Square.");
            Console.WriteLine("Enter square side length :");
            double length = Convert.ToDouble(Console.ReadLine());
            Square newUserSquare = new Square(length);
            Console.WriteLine($"Square Area is : {newUserSquare.GeneralArea()}");
            Console.WriteLine($"Square Perimeter is : {newUserSquare.GeneralPerimeter()}");
            Console.WriteLine("To continue, press <ENTER>");
            Console.ReadLine();
            return newUserSquare;
        }
    }
}
