Console.Write("Введите натуральное 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        NaturalNumbers(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    if (num1 < num2)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    if (num1 == num2) Console.Write($"{num2} "); return;
}
