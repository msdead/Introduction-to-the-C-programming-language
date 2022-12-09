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

void RowColumnsMinElem(int[,] matrix, out int indexRow, out int indexColumn)
{
    int min = matrix[0, 0];
    indexRow = 0;
    indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }        
        }
    }
}

int[,] DeleteRowColumnsMatrix(int[,] matrix, int indexRow, int indexColumn)
{   
    int[,] matrix2 = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        int n = 0;
        if (m == indexRow) m++;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (n == indexColumn) n++;
            matrix2[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return matrix2;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 50);
PrintMatrix(matrix);
Console.WriteLine();
int rowIndex1, columnIndex1;
RowColumnsMinElem(matrix, out rowIndex1, out columnIndex1);
int[,] matrix2 = DeleteRowColumnsMatrix(matrix, rowIndex1, columnIndex1);
PrintMatrix(matrix2);