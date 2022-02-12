using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string cmd;
            while ((cmd = Console.ReadLine()) != "3:1")
            {
                List<string> command = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                int param1 = int.Parse(command[1]);
                int param2 = int.Parse(command[2]);
                if (command[0] == "merge")
                {
                    if (param1 < 0)
                    {
                        param1 = 0;
                    }
                    if (param2 >= input.Count)
                    {
                        param2 = input.Count - 1;
                    }
                    if (param1 >= input.Count)
                    {
                        continue;
                    }
                    StringBuilder mergetCell = new StringBuilder();
                    for (int i = param1; i <= param2; i++)
                    {
                        mergetCell.Append(input[i]);
                    }
                    for (int i = param2; i >= param1; i--)
                    {
                        input.RemoveAt(i);
                    }
                    input.Insert(param1, mergetCell.ToString());
                }    
                
                if (command[0] == "divide")
                {
                    if (param1 >= 0 && param1 < input.Count)
                    {
                        string temp = input[param1];
                        int partLeft = temp.Length% param2;
                        int partSize = (temp.Length - partLeft)/ param2;
                        List<string> parts = new List<string>();
                        int counter = 0;
                        string part = "";
                        for (int i = 0; i < temp.Length - partLeft; i++)
                        {
                            part += temp[i];
                            counter++;

                            if (counter >= partSize)
                            {
                                parts.Add(part);
                                counter = 0;
                                part = "";
                            }
                        }
                        if (partLeft !=0 && parts.Count != 0)
                        {
                            for (int i = temp.Length-partLeft; i < temp.Length; i++)
                            {
                                parts[parts.Count - 1] += temp[i];
                            }
                        }
                        if (parts.Count != 0)
                        {
                        input.RemoveAt(param1);
                        input.InsertRange(param1, parts);
                        }
                    }
                }
            }
                Console.WriteLine(string.Join(' ', input));
            
        }
    }
}
