using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da matriz quadrada");
            int pos = int.Parse(Console.ReadLine());
            int[,] mat = new int[pos, pos];
            int count = 0;
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($"Digite os números da linha {i}, com espaço entre eles");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < pos; j++)
                {   if (int.Parse(values[j]) < 0)
                        count++;
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("---------------- NÚMEROS NA DIAGONAL -------------------");

            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine(mat[i, i]);
            }
            Console.WriteLine("-------------QUANTIDADE DE NÚMEROS NEGATIVOS------------");
            Console.WriteLine(count);

        }
    }
}