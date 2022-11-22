Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int Sum(int x)
{
    int result = 0;
    while (x > 0)
    {
        result = result + x % 10; 
        x = x / 10;  
    }
    return result;
}
Console.Write(Sum(x));
