int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
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

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    int minIndex = matrix.GetLength(0);
    if (matrix.GetLength(1) < matrix.GetLength(0)) minIndex = matrix.GetLength(1);
    for (int i = 0; i < minIndex; i++)
        sum += matrix[i,i];
    return sum;
}


int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array, "", "", "");
Console.WriteLine();
int sumDiagonalMatrix = SumDiagonalMatrix(array);
Console.Write($"Сумма элементов, находящихся на главной диагонали = {sumDiagonalMatrix}");