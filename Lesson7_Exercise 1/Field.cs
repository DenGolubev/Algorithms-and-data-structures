using System;


namespace Lesson7_Exercise_1
{
    class Field
    {
            

        public int  myField(int n, int m)
        {
			int[,] mass = new int[n + 3, m + 3];

			mass[1, 1] = 1;
			int starti = 1, startj = 1;
			while ((starti < n	) || (startj < m ))
			{
				if (startj == m)
				{
					starti++;
				}
				else
				{
					startj++;
				}

				int i = starti;
				int j = startj;
				while ((i <= n) && j >= 2)
				{
					mass[i, j] = mass[i - 1, j] + mass[i, j - 1] ;
					i++;
					j--;
				}
			}
			return mass[n , m];
		}
    }
}
