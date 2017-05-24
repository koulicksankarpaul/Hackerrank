//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//        {
//            StringBuilder resultString = new StringBuilder();
//            for (int j = 1; j <= (n-i); j++)
//            {
//                resultString.Append(" ");
//            }
//            for (int k = (n-i)+1; k <= n; k++)
//            {
//                resultString.Append("#");
//            }            
//            Console.WriteLine(resultString);
//        }

//        Console.ReadKey();
//    }
//}

using System;
class Solution
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
            Console.WriteLine(new String('#', i + 1).PadLeft(N, ' '));
        Console.ReadKey();
    }
}