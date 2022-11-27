// int[] array = new int[12];

// void RandomArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(-9,10);
//     }
// }

// void PrintArray(int[]array)
// {
//     int min = 0;
//     int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         { 
//             min = min + array[i];
//             Console.Write($"{array[i]} ");
//         }
//         else if(array[i] > 0)
//         {
//             max = max + array[i];
//             Console.Write($"{array[i]} ");
//         }
//         else
//         {
//         Console.Write($"{array[i]} ");
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма положительных чисел --> {max} ");
//     Console.WriteLine($"Сумма отрицательных чисел --> {min} ");
// }

// RandomArray(array);
// PrintArray(array);


int [] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd =new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");    
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int [] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < 0) sumNegative += arr[i]; //sumNegative = sumNegative + arr[i];
    return sumNegative;
}

int GetSumPositiveElem(int [] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) sumPositive += arr[i]; //sumPositive = sumPositive + arr[i];
    return sumPositive;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNegative = GetSumNegativeElem(array);
int sumPositive = GetSumPositiveElem(array);
Console.WriteLine($"Сумма отрицательных чисел --> {sumNegative} ");
Console.WriteLine($"Сумма положительных чисел --> {sumPositive} ");