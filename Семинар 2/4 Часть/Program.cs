int number = new Random().Next(10, 1000);
int number1 = 7;
int number2 = 23;

Console.WriteLine($"Данное число --> {number}");
Console.WriteLine($"Первое число --> {number1}");
Console.WriteLine($"Второе число --> {number2}");

bool Multiplicity(int number)
{
    if(number % number1 == 0 && number % number2 == 0)
        return true;
    return false;
}

bool result = Multiplicity(number);
Console.WriteLine(result ? "Кратно" : "Не кратно");
