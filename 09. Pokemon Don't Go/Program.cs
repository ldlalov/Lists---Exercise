using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void CathcPokemon(List<int> pokemons,int temp)
        {
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
        }
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int temp = 0;
                if (index < 0)
                {
                    temp = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    CathcPokemon(pokemons, temp);
                    sum += temp;
                }
                else if (index > pokemons.Count - 1)
                {            
                    temp = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    CathcPokemon(pokemons, temp);
                    sum += temp;
                }
                else
                {
                    temp = pokemons[index];
                    pokemons.RemoveAt(index);
                    sum += temp;
                    CathcPokemon(pokemons, temp);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
