using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,bool>();
            dict.Add("10:00-11:00", true);
            dict.Add("11:00-12:00", true);
            dict.Add("12:00-13:00", true);
            dict.Add("13:00-14:00", true);
            dict.Add("14:00-15:00", true);
            dict.Add("15:00-16:00", true);
            dict.Add("16:00-17:00", true);
            dict.Add("17:00-18:00", true);

            foreach (var d in dict)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            dict["10:00-11:00"] = false;
            foreach (var d in dict)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }
    }
}
