using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> field = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int theBomb = bomb[0];
            int blast = bomb[1];
            int bombPosition = field.IndexOf(theBomb);
            while (bombPosition > -1)
            {
                for (int i = bombPosition - blast; i < bombPosition; i++)
                {
                    if (i >= 0 && i < field.Count)
                    {
                        field.RemoveAt(i);
                        i--;
                        bombPosition--;

                    }
                }

                for (int i = bombPosition; i <= bombPosition + blast; i++)
                {
                    if (i>=0 && i < field.Count)
                    {
                        field.RemoveAt(i);
                        i--;
                        bombPosition--;
                    }
                }
                bombPosition = field.IndexOf(theBomb);
            }
            int sum = 0;
            foreach (var num in field)
            {
                sum += num;
            }
                Console.WriteLine(sum);

        }
    }
}
