using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_b4_b5
{
    public class square : Shape, IsLegal
    {
        public double SideLength { get; set; }
        public double Area { get; private set; }

        public square(double sideLength)
        {
            SideLength = sideLength;
        }

        public bool IsShapeLegal()
        {
            if (SideLength > 0)
            {
                return true;
            }

            return false;
        }


        override public double AreaCalculate()
        {
            if (IsShapeLegal())
            {
                return Area = SideLength * SideLength;
            }

            return Area = -1;
        }

        public override string ToString()
        {
            if (Area != -1)
            {
                return "Square(Legal  SideLength = " + SideLength + " Area = " + Area + ")";
            }

            return "Square(Illegal  SideLength = " + SideLength + ")";
        }
    }
}
