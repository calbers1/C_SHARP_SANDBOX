using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_SANDBOX
{
    //This class represents a uniform panel (i.e. all sides are the same length.)
    class Panel
    {
        public int sides;
        public int sideLength;


        public Panel(int sideNumberInput, int sideLengthInput)
        {
            sides = sideNumberInput;
            sideLength = sideLengthInput;
        }
    }
}
