int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 4}, ");
            else
                Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

// int[,] Sqwirt(int[,] arr)
// {
//     int[,] matrix = new int [arr.GetLength(0), arr.GetLength(1)];
//     int numb = 1;
//     int i, j;
//     for (i = 0; i < arr.GetLength(0); i = i++)
//     {
//         for (j = 0; j < arr.GetLength(1); j = j++)
//         {
//             matrix[i, j] = 1;
//             // numb++;
//         }
//         matrix[i, j] = 2;
//         // numb++;
//     }
//     return matrix;
// }

int[,] array = CreateMatrixRndInt(4, 4);
PrintMatrix(array);
Console.WriteLine();
int[,] array1 = Sqwirt(array);
PrintMatrix(array1);

// int [,] array1 = Sqwirt(array);
// PrintMatrix(array1);
