int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int random;
    Random rnd = new Random();
    int[] arr = new int [rows * columns * depth];
    int m = 0;
    while (m < arr.Length)
    {
        random = rnd.Next(10,100);
        bool b = true;
        for (int i = 0; i < m; i++)
            if (random == arr[i])
            {
                b = false;
                break;
            }
        if (b)
        {
            arr[m] = random;
            m++;
        }
    }
    int count = 0;
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = arr[count];
                count++;
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j, k], 3} ({i}, {j}, {k}),  ");
                else
                Console.Write($"{matrix[i, j, k], 3} ({i}, {j}, {k}) ");
            }

        }
        Console.WriteLine("|");
    }
}

void Сonclusion (out int rows, out int columns, out int depth)
{
    Console.Write("Выберите количество строк матрицы: ");
    rows = 0;
    while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }

    Console.Write("Выберите количество столбцов матрицы: ");
    columns = 0;
    while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }

    Console.Write("Выберите глубину матрицы: ");
    depth = 0;
    while (!int.TryParse(Console.ReadLine(), out depth) || depth <= 0)
    {
        Console.Write("Введено неверное число. Введите число > 0:  ");
    }

    if (rows * columns * depth > 90)
    {
        Console.WriteLine("При заданных параметрах двузначные числа будут повторяться, что не удовлетворяет условиям задачи. Повторите снова.");
        Сonclusion(out rows,out columns,out depth);
    }
}


int rows, columns, depth;
Сonclusion(out rows, out columns, out depth);

Console.WriteLine();

int[,,] array1 = CreateMatrixRndInt(rows, columns, depth);

PrintMatrix(array1);