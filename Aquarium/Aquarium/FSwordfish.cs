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
            TypeF = "Swordfish";
            Speed = 1;
            Size = 4;
            MoveSpeedUpAndDown = 200;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
