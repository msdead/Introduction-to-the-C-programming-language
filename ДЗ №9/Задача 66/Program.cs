Console.Write("Введите натуральное 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNum(int num1, int num2)
{
    if (num1 != num2)
    {
        if (num1 > num2)
        {
            num2 = num2 + SumNum(num1, num2 + 1);
            return (num2);
        }
        if (num1 < num2)
        {
            num1 = num1 + SumNum(num1 + 1, num2);
            return (num1);
        }
    }
    return num1;
}

Console.Write(SumNum(number1, number2));
