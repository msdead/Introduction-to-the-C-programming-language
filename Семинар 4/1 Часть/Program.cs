Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
        Console.WriteLine(sum);
    }
    return sum;
}
SumDigits(number);