using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise_1
{
    class GenerateAnyPointStruct
    {
        float[] myarrayF = new float[1000];
        double[] myarrayD = new double[1000];
        
        public float[] CreateMyArrayF()
        {
            PointFloat pointFloat = new PointFloat();
            for (int i = 0; i < myarrayF.Length; i++)
            {
                myarrayF[i] = pointFloat.GeneratePointF();
            }
            return myarrayF;
        }
        public void CalculatingPointStructFsqrt()
        {
            CreateMyArrayF();
            float x = 0;
            float y = 0;
            
            for (int i = 0; i < myarrayF.Length; i++)
            {
                if (i % 2 == 0) x = myarrayF[i];
                else y = myarrayF[i];
                Math.Sqrt((x * x) + (y * y));
               
            }
        }

        public void CalculatingPointStructF()
        {
            CreateMyArrayF();
            float x = 0;
            float y = 0;
            float z = 0;

            for (int i = 0; i < myarrayF.Length; i++)
            {
                if (i % 2 == 0) x = myarrayF[i];
                else y = myarrayF[i];
                z = (x * x) + (y * y);

            }
        }

        public double[] CreateMyArrayDsqrt()
        {
            PointDouble pointD = new PointDouble();
            for (int i = 0; i < myarrayF.Length; i++)
            {
                myarrayD[i] = pointD.GeneratePointD();
            }
            return myarrayD;
        }
        public void CalculatingPointStructDsqrt()
        {
            CreateMyArrayDsqrt();
            double x = 0;
            double y = 0;
            
            for (int i = 0; i < myarrayD.Length; i++)
            {
                if (i % 2 == 0) x = myarrayD[i];
                else y = myarrayF[i];
                Math.Sqrt((x * x) + (y * y));
                
            }
        }


    }
}
