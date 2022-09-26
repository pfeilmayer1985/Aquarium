using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public abstract class Fish
    {
        public string Look { get; set; }
        public string BasicLook { get; set; }
        public string InvertedLook { get; set; }
        public int Size { get; set; }
        public double MoveSpeedUpAndDown { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool SwimDirection { get; set; }
        public bool SwimDepth { get; set; }

       
    }
}
