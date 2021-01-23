using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise_1
{
    class PointClass
    {
        public float Point;
        Random rnd = new Random();
        
        public float GeneratePoint()
        {
            Point = (float)rnd.NextDouble() * 100;
            return Point;
        }

    }
}
