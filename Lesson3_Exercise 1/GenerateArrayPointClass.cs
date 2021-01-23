using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise_1
{
    class GenerateArrayPointClass
    {
        PointClass newPoint = new PointClass();
        float[] myarray = new float[1000];
        public float[] CreateMyArray()
        {
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = newPoint.GeneratePoint();
            }
            return myarray;
        }
        public void CalculatingPointClassFloat()
        {
            CreateMyArray();
            float x = 0;
            float y = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (i % 2 == 0) x = myarray[i];
                else y = myarray[i];
                Math.Sqrt((x * x) + (y * y));
            }
        }
    }
}
