int index = 0;
int holiday1 = 6;
int holiday2 = 7;
Console.WriteLine("Введите число обозначающую день недели, от 1 до 7");
while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > 7)
{
Console.WriteLine("Введено неверное число. Введите число обозначающую день недели, от 1 до 7");
}
bool Holiday()
{
    return index == holiday1 || index == holiday2;
}
bool result = Holiday();
Console.WriteLine(result ? "Выходной" : "Рабочий день");