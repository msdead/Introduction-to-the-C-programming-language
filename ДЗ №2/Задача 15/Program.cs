int holiday1 = 6;
int holiday2 = 7;

Console.WriteLine("Введите число обозначающую день недели, от 1 до 7");
int index = Convert.ToInt32(Console.ReadLine());

bool Holiday()
{
    return index == holiday1 || index == holiday2;
}
bool result = Holiday();
Console.WriteLine(result ? "Выходной" : "Рабочий день");
