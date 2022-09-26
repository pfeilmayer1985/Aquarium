using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPractice
{
    public abstract class Geometry
    {
        public string GeometryName { get; set; }    
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Geometry()
        { }
        public Geometry(double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
        }

        public double GeneralArea()
        {
            return Area;
        }

        public double GeneralPerimeter()
        {
            return Perimeter;
        }

        

    }
}
