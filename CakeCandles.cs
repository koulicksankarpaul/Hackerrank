using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, Int32.Parse);
        int noOfCandles = 1;
        Array.Sort(height);

        for (int i = height.Length; i > 0; i--)
        {
            if (i > 1)
            {
                if (height[i - 1] > height[i - 2])
                {
                    break;
                }
                if (height[i - 1] == height[i - 2])
                {
                    noOfCandles += 1;
                }
            }
        }
        Console.WriteLine(noOfCandles);
        Console.ReadKey();
    }
}
