using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_b4_b5
{
    public class shape_factory
    {
        //使用随机数生成形状中长宽高，边长等属性
        private Random rand;

        public shape_factory()
        {
            rand = new Random();
        }

        //根据shape类型返回不同的形状
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new rectangle(rand.Next(21), rand.Next(21));
            }
            else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new square(rand.Next(21));
            }
            else if (shapeType.Equals("TRIANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new triangle(rand.Next(21), rand.Next(21), rand.Next(21));
            }

            return null;
        }
    }
}
