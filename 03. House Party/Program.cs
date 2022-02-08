using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            List<string> guestlist = new List<string>();
            for (int i = 0; i < guests; i++)
            {
                List<string> visitors = Console.ReadLine().Split().ToList();
                    if (!guestlist.Contains(visitors[0]))
                    {
                        if (visitors[2]=="going!")
                        {
                            guestlist.Add(visitors[0]);
                        }
                        else if (visitors[2] == "not")
                        {
                            Console.WriteLine($"{visitors[0]} is not in the list!");
                        }
                    }
                    else if (guestlist.Contains(visitors[0]))
                    {
                        if (visitors[2]=="going!")
                        {
                            Console.WriteLine($"{visitors[0]} is already in the list!");
                        }
                        else if (visitors[2] == "not")
                        {
                            guestlist.Remove(visitors[0]);
                        }
                    }
            }
            for (int j = 0; j < guestlist.Count; j++)
            {
                Console.WriteLine(guestlist[j]);
            }

        }
    }
}
