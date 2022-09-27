using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FFood : Fish
    {
        public FFood(int xPos, int yPos)
        {
            Look = ".";
            BasicLook = ".";
            InvertedLook = "*";
            TypeF = "Food";
            Speed = 0;
            Size = 1;
            MoveSpeedUpAndDown = 1;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
