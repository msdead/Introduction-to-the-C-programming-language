Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
while (b < 0)
    {
        Console.WriteLine("Введено не натуральное число. Введите натуральное число B");
        b = Convert.ToInt32(Console.ReadLine());
    }


double MultDigits(double res)
{
    double result = Math.Pow(a, b);
    Console.Write(result);
    return result;
}

MultDigits(a);