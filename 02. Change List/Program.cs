using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> cmd = input.Split().ToList();
                switch (cmd[0])
                {
                    case "Delete":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums.Remove(int.Parse(cmd[1]));
                        }
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', nums));
        }
    }
}
