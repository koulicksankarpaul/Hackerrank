using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string time = Console.ReadLine();
        string output = "";
        string timeOfDayOrNight = time.Substring(8, 2);
        string[] slices = time.Split(':');

        if (timeOfDayOrNight == "AM")
        {            
            if (Convert.ToInt32(slices[0]) <= 11)
            {
                output = time.Substring(0, 8);
            }
            else
            {
                if (time == "12:00:00AM")
                {
                    output = "00:00:00";
                }
                else
                {
                    string remaining = time.Substring(2, 6);
                    output = "00" + remaining;
                }
            }            
        }
        else //PM
        {
            if (Convert.ToInt32(slices[0]) <= 11)
            {
                string hours = time.Substring(0, 2);
                int hoursConverted = Convert.ToInt32(hours) + 12;
                string remaining = time.Substring(2, 6);
                output = hoursConverted.ToString() + remaining;
            }
            else
            {
                if (time == "12:00:00PM")
                {
                    output = "12:00:00";
                }
                else
                {
                    output = time.Substring(0, 8);
                }
            }
        }
        Console.WriteLine(output);
        Console.ReadKey();
    }
}