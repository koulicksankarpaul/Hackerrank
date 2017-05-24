using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i==j)
                {
                    primaryDiagonal += a[i][j];
                }

                if ((i + j) == (n-1))
                {
                    secondaryDiagonal += a[i][j];
                }
            }
        }
        
        Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        Console.ReadKey();
    }
}
