using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FCarp : Fish
    {

        public FCarp(int xPos, int yPos)
        {
            Look = "<><";
            BasicLook = "<><";
            InvertedLook = "><>";
            TypeF = "Carp";
            Speed = 1;
            Size = 3;
            MoveSpeedUpAndDown = 50;
            XPosition = xPos;
            YPosition = yPos;
        }
        //public FCarp() { }

        

    }


}
