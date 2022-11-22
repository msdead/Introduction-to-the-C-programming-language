Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

void Palindrome(int x)
{
    if( 9999 < x && x < 100000)
    {
        int x1 = x/ 10;
        int n5 = x % 10;
        int x2 = x1/ 10;
        int n4 = x1 % 10;
        int x3 = x2/ 10;
        int n3 = x2 % 10;
        int x4 = x3/ 10;
        int n2 = x3 % 10;
        int x5 = x4/ 10;
        int n1 = x4 % 10;
        double res = n1 + n2 * 10 + n3 * Math.Pow(10, 2) + n4 * Math.Pow(10,3) + n5 * Math.Pow(10, 4);

        if (res == x)
        {
            Console.WriteLine("Число ЯВЛЯЕТСЯ палиндромом");
        }
        else 
        {
            Console.WriteLine("Число НЕ является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Неверно введенное число");
    }
}
Palindrome(x);