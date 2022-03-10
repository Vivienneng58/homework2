using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_b4_b5
{
    public class triangle : Shape , IsLegal
    {
        public double FirstSideLength { get; set; }
        public double SecondSideLength { get; set; }
        public double ThirdSideLength { get; set; }
        public double Area { get; private set; }

        public triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            ThirdSideLength = thirdSideLength;
        }

        public bool IsShapeLegal()
        {
            if (FirstSideLength <= 0 || SecondSideLength <= 0 || ThirdSideLength <= 0)
            {
                return false;
            }

            if ((FirstSideLength + SecondSideLength) <= ThirdSideLength)
            {
                return false;
            }

            if ((FirstSideLength + ThirdSideLength) <= SecondSideLength)
            {
                return false;
            }

            if ((SecondSideLength + ThirdSideLength) <= FirstSideLength)
            {
                return false;
            }

            return true;
        }

        override public double AreaCalculate()
        {
            if (IsShapeLegal())
            {
                double a = FirstSideLength;
                double b = SecondSideLength;
                double c = ThirdSideLength;
                double p = (a + b + c) / 2;
                return Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            return Area = -1;
        }

        public override string ToString()
        {
            if (Area != -1)
            {
                return "Triangle(Legal  FirstSideLength = " + FirstSideLength + " SecondSideLength = " + SecondSideLength + " ThirdSideLength = " + ThirdSideLength + " Area = " + Area + ")";
            }

            return "Triangle(Illegal  FirstSideLength = " + FirstSideLength + " SecondSideLength = " + SecondSideLength + " ThirdSideLength = " + ThirdSideLength + ")";
        }
    }
}
