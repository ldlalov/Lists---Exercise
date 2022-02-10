using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fistHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (fistHand.Count!=0 && secondHand.Count!=0)
            {
                    if (fistHand[0] > secondHand[0])
                    {
                        fistHand.Add(secondHand[0]);
                        fistHand.Add(fistHand[0]);
                        secondHand.Remove(secondHand[0]);
                        fistHand.Remove(fistHand[0]);
                    }
                    else if (secondHand[0] > fistHand[0])
                    {
                        secondHand.Add(fistHand[0]);
                        secondHand.Add(secondHand[0]);
                        fistHand.Remove(fistHand[0]);
                        secondHand.Remove(secondHand[0]);
                    }
                    else
                    {
                        fistHand.Remove(fistHand[0]);
                        secondHand.Remove(secondHand[0]);
                    }
            }
            int sum = 0;
            if (fistHand.Count>secondHand.Count)
            {
                foreach (var item in fistHand)
                {
                    sum += item;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                foreach (var item in secondHand)
                {
                    sum += item;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
