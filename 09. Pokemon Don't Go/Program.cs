using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sum = 0;
            while (pokemons.Count > 0)
            {
                sum += pokemons[index];
                int temp = pokemons[index];
                //if (index<0)
                //{
                //    pokemons[pokemons.Count - 1] = pokemons[0];
                //}
                //else if (index>pokemons.Count-1)
                //{
                //    pokemons[0] = pokemons.Count;
                //}
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= temp)
                    {
                        pokemons[i] += temp;
                    }
                    else
                    {
                        pokemons[i] -= temp;
                    }
                }
                pokemons.RemoveAt(index);
            }
            Console.WriteLine(sum);
        }
    }
}
