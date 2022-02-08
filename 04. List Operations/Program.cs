using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                List<string> command = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch(command[0])
                {
                    case "Add":
                        list1.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > list1.Count())
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list1.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > list1.Count())
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list1.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int temp = list1.First();
                                list1.RemoveAt(0);
                                list1.Add(temp);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int temp = list1.Last();
                                list1.RemoveAt(list1.Count()-1);
                                list1.Insert(0, temp);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', list1));
        }
    }
}
