﻿Console.WriteLine("Выберите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,100);
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

RandomArray(array);
PrintArray(array);