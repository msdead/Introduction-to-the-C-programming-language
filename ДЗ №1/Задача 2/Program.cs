Console.WriteLine("Введите целое число 'a': ");
int a = Convert.ToInt32(Console.ReadLine());
int max = a;
Console.WriteLine("Введите целое число 'b': ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a) max = b;
Console.WriteLine($"Максимальное введенное число = {max} ");