Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// 1 Вар.

// int count = 0;
// while(number > 1)
// {
//     number = number / 10;
//     count++;
// }
// Console.WriteLine(count);


// 2 Вар.

// int NumLength(int num)
// {
//     int n = 1;
//     for (int i = 0; i < 10; i++)
//     {
//         num = num / 10;
//         if (num != 0) n++;
//         else break;
//     }
//     return n;
// }
// int numLength = NumLength(num: number);
// Console.WriteLine(numLength);