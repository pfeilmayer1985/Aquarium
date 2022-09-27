using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FShark : Fish
    {
        public FShark(int xPos, int yPos)
        {
            Look = "<///====><";
            BasicLook = "<///====><";
            InvertedLook = "><====///>";
            TypeF = "Shark";
            Speed = 1;
            Size = 6;
            MoveSpeedUpAndDown = 25;
            XPosition = xPos;
            YPosition = yPos;
        }

    }
}
