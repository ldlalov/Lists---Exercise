using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string passengers;
            while ((passengers = Console.ReadLine()) != "end")
            {
                List<string> cmd = passengers.Split().ToList(); 
                if (cmd[0]=="Add")
                {
                    vagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    for (int i = 0; i < vagons.Count; i++)
                    {
                        if (vagons[i] + int.Parse(cmd[0]) <= capacity)
                        {
                            vagons[i] += int.Parse(cmd[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(' ', vagons));
        }
    }
}
