using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            List<int> finalList = new List<int>();
            for (int i = arrays.Count -1; i >=0 ; i--)
            {
                List<int> tempList = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < tempList.Count; j++)
                {
                finalList.Add(tempList[j]);
                }
            }
            Console.WriteLine(String.Join(' ',finalList));
        }
    }
}
