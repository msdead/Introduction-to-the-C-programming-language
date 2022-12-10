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

int[,] GetMultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] arr = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arr[i, j] = arr[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return arr;
}

void Сonclusion (out int a1, out int a2, out int b1, out int b2, out int n, out int m)
{
    Console.Write("Выберите количество строк матрицы А: ");
    a1 = 0;
    while (!int.TryParse(Console.ReadLine(), out a1) || a1 <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }

    Console.Write("Выберите количество столбцов матрицы А: ");
    a2 = 0;
    while (!int.TryParse(Console.ReadLine(), out a2) || a2 <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }
    
    Console.Write("Выберите количество строк матрицы B: ");
    b1 = 0;
    while (!int.TryParse(Console.ReadLine(), out b1) || b1 <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }
    
    Console.Write("Выберите количество столбцов матрицы B: ");
    b2 = 0;
    while (!int.TryParse(Console.ReadLine(), out b2) || b2 <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }
    
    Console.Write("Введите число счета от: ");
    n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число счета до: ");
    while (!int.TryParse(Console.ReadLine(), out m) || m < n)
    {
        Console.Write($"Введено неверное число. Введите число > или = {n}:  ");
    }
}


int a1, a2, b1, b2, n, m;
Сonclusion(out a1, out a2, out b1, out b2, out n, out m);

Console.WriteLine();

int[,] array1 = CreateMatrixRndInt(a1, a2, n, m);
PrintMatrix(array1);

Console.WriteLine();

int[,] array2 = CreateMatrixRndInt(b1, b2, n, m);
PrintMatrix(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}

Console.WriteLine();

int[,] array3 = GetMultiplicationMatrix(array1, array2);
PrintMatrix(array3);