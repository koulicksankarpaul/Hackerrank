using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        decimal positiveNumbers = 0, negativeNumbers = 0, zeroNumbers = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                positiveNumbers += 1;
            }
            else if (arr[i] < 0)
            {
                negativeNumbers += 1;
            }
            else
            {
                zeroNumbers += 1;
            }
        }

        Console.WriteLine((positiveNumbers / n).ToString("N6"));
        Console.WriteLine((negativeNumbers / n).ToString("N6"));
        Console.WriteLine((zeroNumbers / n).ToString("N6"));
        Console.ReadKey();
    }
}
