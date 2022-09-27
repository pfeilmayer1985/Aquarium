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
            TypeF = "Blowfish";
            Speed = 1;
            Size = 5;
            MoveSpeedUpAndDown = 100;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
