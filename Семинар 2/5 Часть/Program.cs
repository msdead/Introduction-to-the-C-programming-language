int number1 = new Random().Next(10, 100);
int number2 = new Random().Next(10, 100);

Console.WriteLine($"Первое число --> {number1}");
Console.WriteLine($"Второе число --> {number2}");

bool Multiplicity()
{
return (number2 == number1 * number1 || number1 == number2 * number2);
}
bool result = Multiplicity();
Console.WriteLine(result ? "Кратно" : "Не кратно");