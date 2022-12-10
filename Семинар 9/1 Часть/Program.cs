Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers (num - 1);
    Console.Write($"{num} ");
}

NaturalNumbers(number);