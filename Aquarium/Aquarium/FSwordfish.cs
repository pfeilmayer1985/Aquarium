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
            BasicLook = "-<><";
            InvertedLook = "><>-";
            Size = 4;
            MoveSpeedUpAndDown = 0.2;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
