Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a) max = b;
else
{
min = b;
}
Console.WriteLine($"Максимальное введенное число = {max} ");
Console.WriteLine($"Минимальное введенное число = {min} ");