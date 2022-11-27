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
        else Console.Write($"{arr[i]}");    
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int [] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 1) sumNegative += arr[i]; 
    return sumNegative;
}

int[] array = CreateArrayRndInt(10, -100, 100);
PrintArray(array);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях индекса = {GetSumNegativeElem(array)}");

