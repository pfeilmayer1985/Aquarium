using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FSwordfish : Fish
    {
        public FSwordfish(int xPos, int yPos)
        {
            Look = "-<><";
            Size = 2;
            MoveSpeedLeftAndRight = 0.2;
            MoveSpeedUpAndDown = 0.2;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
