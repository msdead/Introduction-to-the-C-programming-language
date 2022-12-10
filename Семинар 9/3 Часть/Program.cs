Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumNum(number);

int SumNum(int num)
{
    return num !=0 ? num % 10 + SumNum(num/10) : 0;
} 

Console.WriteLine(SumNum(Math.Abs(number)));