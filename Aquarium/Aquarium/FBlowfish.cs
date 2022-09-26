using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FBlowfish : Fish
    {

        public FBlowfish(int xPos, int yPos)
        {
            Look = "<()><";
            BasicLook = "<()><";
            InvertedLook = "><()>";
            Size = 5;
            MoveSpeedUpAndDown = 0.1;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
