using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Fisch
    {
        public string Look { get; set; }
        public string Size { get; set; }
        public int MoveSpeedLeft { get; set; }
        public int MoveSpeedRight { get; set; }
        public double MoveSpeedUp { get; set; }
        public double MoveSpeedDown { get; set; }

        public Fisch(string look, string size, int moveSpeedLeft, int moveSpeedRight, double moveSpeedUp, double moveSpeedDown)
        {
            Look = look;
            Size = size;
            MoveSpeedLeft = moveSpeedLeft;
            MoveSpeedRight = moveSpeedRight;
            MoveSpeedUp = moveSpeedUp;
            MoveSpeedDown = moveSpeedDown;
        }
    }
}
