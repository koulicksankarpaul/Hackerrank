using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        
        long[] sum = new long[arr.Length];
        long temp = 0;

        for (int i = 0; i < arr.Length; i++) //arr.Length will be 5
        {
            temp += arr[i];
        }
        for (int j = 0; j < arr.Length; j++)
        {
            sum[j] = temp - arr[j];
        }
        Array.Sort(sum);
        Console.Write(sum[0]);
        Console.Write(" ");
        Console.Write(sum[arr.Length - 1]);
        Console.ReadKey();
    }
}