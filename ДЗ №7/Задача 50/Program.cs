double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void Сonclusion (double[,] matrix)
{
    Console.Write("Выберите позицию строки: ");
    int i = 0;
    while (!int.TryParse(Console.ReadLine(), out i) || i <= 0)
{
    Console.Write("Введено неверное число. Введите число > 0:  ");
}
    Console.Write("Выберите позицию столбца: ");
    int j = 0;
    while (!int.TryParse(Console.ReadLine(), out j) || j <= 0)
{
    Console.Write("Введено неверное число. Введите число > 0:  ");
}

    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
        Console.WriteLine($"Число на указанной позиции {i},{j} ==> {matrix[i-1,j-1]}");
    else Console.WriteLine("Число на указанной позиции отсутствует");
}

double[,] array = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array);
Сonclusion(array);