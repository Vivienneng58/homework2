using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_b4_b5
{
    public class rectangle : Shape , IsLegal
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; private set; }

        public rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public bool IsShapeLegal()
        {
            if (Width > 0 && Height > 0)
            {
                return true;
            }

            return false;
        }

        //返回-1说明形状不合法
        override public double AreaCalculate()
        {
            if (IsShapeLegal())
            {
                return Area = Width * Height;
            }

            return Area = -1;
        }

        public override string ToString()
        {
            if (Area != -1)
            {
                return "Rectangle(Legal  Width = " + Width + " Height = " + Height + " Area = " + Area + ")";
            }

            return "Rectangle(Illegal  Width = " + Width + " Height = " + Height + ")";
        }
    }
}
