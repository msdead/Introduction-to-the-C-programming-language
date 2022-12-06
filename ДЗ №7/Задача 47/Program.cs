﻿double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1); 
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 5}, ");
            else
                Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array);