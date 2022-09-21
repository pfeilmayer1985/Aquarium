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
            Size = 3;
            MoveSpeedLeftAndRight = 0.1;
            MoveSpeedUpAndDown = 0.1;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
