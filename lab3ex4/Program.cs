using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter size of matrix:\nm = ");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] array1 = new int[m, n];
            int[,] array2 = new int[m, n];
            int[,] result1 = new int[m, n];
            int[,] result2 = new int[m, n];

            Random randomNumber = new Random();
            RandomMatrize(array1, randomNumber);
            RandomMatrize(array2, randomNumber);
            WriteMatrix(array1);
            WriteMatrix(array2);
            result1 = AddMatrixes(array1, array2, out double averageAdd);
            WriteMatrix(result1);
            result2 = SubtractMatrixes(array1, array2, out double averageSubtract);
            WriteMatrix(result2);
            Console.Write($"Average of addition {averageAdd}\nAverage of subtraction {averageSubtract}\n");
            Console.ReadKey();
        }
        static void RandomMatrize(int[,] array, Random random)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                }
            }
        }
        static void WriteMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        static int[,] AddMatrixes(int[,] array1, int[,] array2, out double averageAdd)
        {
            int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
            averageAdd = 0;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    result[i, j] = array1[i, j] + array2[i, j];
                    averageAdd += result[i, j];
                }
            }
            averageAdd = Math.Round(averageAdd / (array1.GetLength(0) * array1.GetLength(1)), 1);
            return result;
        }
        static int[,] SubtractMatrixes(int[,] array1, int[,] array2, out double averageSubtract)
        {
            int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
            averageSubtract = 0;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    result[i, j] = array1[i, j] - array2[i, j];
                    averageSubtract += result[i, j];
                }
            }
            averageSubtract = Math.Round(averageSubtract / (array1.GetLength(0) * array1.GetLength(1)), 1);
            return result;
        }
    }
    }
}
