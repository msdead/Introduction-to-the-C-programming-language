int number = new Random().Next(1, 100);
Console.WriteLine($"Случайное число из отрезка --> {number}");
if (number < 100)
{
   Console.WriteLine("Третьего числа нет"); 
   return;
}
while (number >= 1000)
{
 number = number / 10;
}
int result = number % 10;
Console.WriteLine(result);
