using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da matriz quadrada");

            string[] matriz = Console.ReadLine().Split(' ');

            int yPos = int.Parse(matriz[1]);
            int xPos = int.Parse(matriz[0]);
            int[,] mat = new int[xPos, yPos];
            for (int i = 0; i < xPos; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < yPos; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int numberWanted = int.Parse(Console.ReadLine());
            for (int j = 0; j < yPos; j++)
            {
                for (int k = 0; k <= xPos; k++)
                {
                    if (j >= xPos && k == 0)
                    {
                        break;
                    }
                    if (xPos == yPos && k == xPos)
                    {
                        break;
                    }
                    if (mat[j, k] == numberWanted)
                    {
                        Console.WriteLine($"Positio: {j},{k}:");
                        if (k > 0)
                            Console.WriteLine($"Left: {mat[j, k - 1]}:");
                        if (k < xPos-1)
                            Console.WriteLine($"Right: {mat[j, k + 1]}:");
                        if (j > 0)
                            Console.WriteLine($"Up: {mat[j - 1, k]}:");
                        if (j < yPos-1)
                            Console.WriteLine($"Down: {mat[j + 1, k]}:");

                    }
                }

            }
        }
    }
}