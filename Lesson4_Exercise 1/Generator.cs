using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class Generator
    {
        Random rnd = new Random();
        public int[] GenNumbers(int n_start, int n_end)
        {
            int[] masnumber = new int[n_end - 10];
            for (int i = 0; i < masnumber.Length; i++)
            {
                int a = rnd.Next(n_start, n_end);
                if (!masnumber.Contains(a))
                {
                    masnumber[i] = a;
                }
                else i--; 
            }
            return masnumber;
        }

        public string[] GenStringstoArray(int n_end)
        {
            int length = 10;
            string[] masletters = new string[n_end];
            for (int i = 0; i < masletters.Length; i++)
            {
                string a = "";
                for (int y = 0; y < length; y++)
                {
                    if( y % 3 == 0) a += Convert.ToChar(rnd.Next(65, 88));
                    else if( y % 2 == 0) a += Convert.ToChar(rnd.Next(97, 122));
                    else a += Convert.ToChar(rnd.Next(48, 57));
                }
                if (!masletters.Equals(a)) masletters[i] = a;
                else i--;                
            }
            return masletters;
        }

        public HashSet<string> GenStringstoHashSet(int n_end)
        {
            HashSet<string> hashletters = new HashSet<string>();
            var mas = GenStringstoArray(n_end);
            foreach (var item in mas)
            {
                hashletters.Add(item);
            }
            return hashletters;
           
        }
    }
}
