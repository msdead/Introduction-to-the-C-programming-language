int number1 = new Random().Next(10, 100);
int number2 = new Random().Next(1, 10);

Console.WriteLine($"Первое случайное число из отрезка 10-99 --> {number1}");
Console.WriteLine($"Второе случайное число из отрезка 1-9 --> {number2}");

bool Multiplicity(int number1, int number2)
{
    if (number1 % number2 == 0)
        return true;
    return false;
}
bool result = Multiplicity(number1, number2);
Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток = {number1 % number2}");
