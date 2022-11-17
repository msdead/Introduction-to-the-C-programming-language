// 1 Вариант с генератором случайных чисел\

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100-999 --> {number}");
// int result1 = number % 100;
// int result2 = result1 / 10;
// Console.WriteLine($"Вторая цифра трёхзначного числа --> {result2}");

// 2 Вариант с ручным вводом чисел

// int number = 0;
// Console.WriteLine("Введите трехзначное число из отрезка 100-999");
// while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
// {
//     Console.WriteLine("Введено неверное число. Введите трехзначное число, от 100 до 999");
// }
// int result1 = number % 100;
// int result2 = result1 / 10;
// Console.WriteLine($"Вторая цифра трёхзначного числа --> {result2}");
