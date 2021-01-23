using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise_1
{
    struct PointStruct
    {
        public float PointF;
        public double PointD;
    }

    class PointFloat
    {
        Random rnd = new Random();
        PointStruct Point;
       
        public float GeneratePointF()
        {
            Point.PointF = (float)rnd.NextDouble() * 100;
            return Point.PointF;
        }
    }
    class PointDouble
    {
        Random rnd = new Random();
        PointStruct Point;
        public double GeneratePointD()
        {
            Point.PointD = rnd.NextDouble() * 100;
            return Point.PointD;
        }

    }
}
