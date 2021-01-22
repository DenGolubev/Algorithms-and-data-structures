using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Exercise_2
{
    class myArray
    {
        int[] newArray;
        public int[] CreateArray(int arrayrange)
        {
            Random random = new Random();
            newArray = new int[arrayrange];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(1, 100);
            }
            return newArray;
        }
        public int[] myBubbleSort(int[] array)
        {
            newArray = array;
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length - 1; j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        int t = newArray[j + 1];
                        newArray[j + 1] = newArray[j];
                        newArray[j] = t;
                    }
                }
                    
            }
            return newArray;
        }
    }
}
