double [] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd =new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");    
    }
    Console.WriteLine("]");
}

double GetMin (double [] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < min) min = arr[i]; 
    return min;
}

double GetMax(double [] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > max) max = arr[i];
    return max;
}

double Difference(double max ,double min)
{
    double Difference = max - min;
    return Math.Round(Difference, 1);
}

double[] array = CreateArrayRndDouble(5, -100, 100);
PrintArray(array);
double min = GetMin(array);
double max = GetMax(array);
Console.WriteLine($" Разница между максимальным и минимальным элементами массива = {Difference(max, min)}");