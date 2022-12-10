int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[,] SortMatrix(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(1); m++)
            {
                if (arr[i, m] < arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, m];
                    arr[i, m] = temp;
                }
            }
        }
    }
    return arr;
}

int[,] arr = CreateMatrixRndInt(10, 10, 0, 50);
PrintMatrix(arr);
Console.WriteLine();
SortMatrix(arr);
PrintMatrix(arr);