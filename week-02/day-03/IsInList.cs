using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var sublist = new List<int> { 4, 8, 12, 16 };
            bool check = false;

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            for (int i = 0; i < sublist.Count; i++)
            {
                if (list.Contains(sublist[i]))
                {
                    check = true;
                }
                else
                {
                    check = false;
                };
            }

            Console.WriteLine(check);

            for (int i = 0; i < sublist.Count; i++)
            {
                if (list.IndexOf(sublist[i])>0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                };
            }

            Console.WriteLine(check);

            Console.ReadLine();
        }
    }
}