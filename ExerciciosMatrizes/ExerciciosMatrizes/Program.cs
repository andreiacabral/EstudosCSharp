using System;

namespace ExerciciosMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, X;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i,j]==X)
                    {
                        Console.WriteLine(mat[i, j - 1]);
                        Console.WriteLine(mat[i+1, j]);
                        Console.WriteLine(mat[i, j + 1]);
                        Console.WriteLine(mat[i - 1, j]);

                    }
                }
            }
        }
    }
}
