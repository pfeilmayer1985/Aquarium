using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool loopGeometry = true;
            List<Geometry> myGeometryObjects = new List<Geometry>();

            while (loopGeometry)
            {
                Console.Clear();
                Console.WriteLine("Choose your geometric shape :");
                Console.WriteLine("1. Circe");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Cube");
                Console.WriteLine("5. Show my geometry objects");
                Console.WriteLine("6. Exit");
                int userShape = Convert.ToInt32(Console.ReadLine());


                switch (userShape)
                {
                    case 1:

                        Circle abcCircle = Circle.MakeNewCircle();
                        myGeometryObjects.Add(abcCircle);

                        break;

                    case 2:

                        Triangle abcTriangle = Triangle.MakeNewTriangle();
                        myGeometryObjects.Add(abcTriangle);

                        break;

                    case 3:

                        Square abcSquare = Square.MakeNewSquare();
                        myGeometryObjects.Add(abcSquare);

                        break;
                    case 4:
                        Cube abcCube = Cube.MakeNewCube();
                        myGeometryObjects.Add(abcCube);

                        break;

                    case 5:
                        int i = 1;
                        foreach (Geometry geometry in myGeometryObjects)
                        {
                            Console.WriteLine($"{i}.You have defined a {geometry.GeometryName} with the Perimeter {geometry.Perimeter} and Area {geometry.Area}.");
                            i++;
                        }
                        Console.WriteLine("To continue, press <ENTER>");

                        Console.ReadLine();


                        break;

                    case 6:

                        loopGeometry = false;
                        break;
                    default:
                        Console.WriteLine("Try again !");
                        Console.ReadLine();

                        break;


                }
            }


        }
    }
}
