using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Fish
    {
        public string Look { get; set; }
        public string Size { get; set; }
        public int MoveSpeedLeftAndRight { get; set; }
        public double MoveSpeedUpAndDown { get; set; }

        public Fish(string look, string size, int moveSpeedLeftAndRight, double moveSpeedUpAndDown)
        {
            Look = look;
            Size = size;
            MoveSpeedLeftAndRight = moveSpeedLeftAndRight;
            MoveSpeedUpAndDown = moveSpeedUpAndDown;
        }
    }
}
