int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 --> {number}");

int result1 = number % 100;
int result2 = result1 / 10;

Console.WriteLine(result2);