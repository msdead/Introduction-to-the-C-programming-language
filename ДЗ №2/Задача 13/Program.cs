int number = new Random().Next(-1000, 1000);
Console.WriteLine($"Случайное число из отрезка --> {number}");
if (-100 < number & number < 100)
{
   Console.WriteLine("Третьего числа нет"); 
   return;
}
while (number >= 1000)
{
   number = number / 10;
}
if (number < 0)
{
   number = number * -1;
}
int result = number % 10;
Console.WriteLine($"Третья цифра числа --> {result}");