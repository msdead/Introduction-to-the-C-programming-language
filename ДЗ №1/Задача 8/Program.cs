Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
if (count % 2 == 0)
Console.WriteLine(count);
count++;
}