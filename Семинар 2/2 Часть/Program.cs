int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 --> {number}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

Console.WriteLine($"Число без второй цифры --> {RemoveSecondDigit(number)}");
