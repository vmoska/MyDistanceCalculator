using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDistanceCalculator
{
    public class Person
    {
        public string Name { get; set; }
        public double CoordinatedX { get; set; }
        public double CoordinatedY { get; set; }

        internal double CalcDistance(Person item)
        {
            MyMath m = new MyMath();

            
            double x = m.SubtractionDouble(CoordinatedX, item.CoordinatedX);
            
            double y = m.SubtractionDouble(CoordinatedY, item.CoordinatedY);


            x = m.ElevDouble(x, 2);
            
            y = m.ElevDouble(y, 2);

            double result = m.CalcSqrt(m.SumDouble(new double[] { x, y }));

            return result;
        }
    }
}
