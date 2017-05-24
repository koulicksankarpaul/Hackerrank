using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        // Complete this function
        int[] result = new int[2];
        int aliceScore = 0;
        int bobScore = 0;

        //compare a0 with b0
        if (a0 > b0)
        {
            aliceScore += 1;
        }
        else if (a0 < b0)
        {
            bobScore += 1;
        }
        else
        {
            //do nothing
        }

        //compare a1 with b1
        if (a1 > b1)
        {
            aliceScore += 1;
        }
        else if (a1 < b1)
        {
            bobScore += 1;
        }
        else
        {
            //do nothing
        }

        //compare a2 with b2
        if (a2 > b2)
        {
            aliceScore += 1;
        }
        else if (a2 < b2)
        {
            bobScore += 1;
        }
        else
        {
            //do nothing
        }
        result[0] = aliceScore;
        result[1] = bobScore;

        return result;
    }

    static void Main(String[] args)
    {
        string[] tokens_alice = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_alice[0]);
        int a1 = Convert.ToInt32(tokens_alice[1]);
        int a2 = Convert.ToInt32(tokens_alice[2]);
        string[] tokens_bob = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_bob[0]);
        int b1 = Convert.ToInt32(tokens_bob[1]);
        int b2 = Convert.ToInt32(tokens_bob[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
        Console.ReadKey();
    }
}
