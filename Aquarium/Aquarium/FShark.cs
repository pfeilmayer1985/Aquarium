using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FShark : Fish
    {
        public FShark()
        {
            Look = "<///====><";
            Size = 5;
            MoveSpeedLeftAndRight = 0.25;
            MoveSpeedUpAndDown = 0.25;
        }

    }
}
