Console.Write("Введите 1 число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

AckermanFunction(num1, num2);

int AckermanFunction(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    if (num1 != 0 && num2 == 0)
        return AckermanFunction(num1 - 1, 1);
    if (num1 > 0 && num2 > 0)
        return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
    return AckermanFunction(num1, num2);
}
Console.WriteLine(AckermanFunction(num1,num2));
