﻿Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

void Square(int x)
{
    for (int i = 1; i <= x; i++)
        {
            Console.WriteLine($"{i}x{i} = {i * i}");
        }
}
Square(x);
