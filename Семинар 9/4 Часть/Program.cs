Console.Write("Введите натуральное 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


SumNum(number1, number2);

int SumNum(int num1, int num2)
{
    return num2 == 0 ? 1 : SumNum(num1, num2 - 1) * num1;
} 

Console.WriteLine(SumNum(number1, number2));