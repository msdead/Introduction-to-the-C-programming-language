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

int [] NewArray (int[] arr)
{
    int newArraySize = arr.Length / 2;
    if (arr.Length % 2 == 1) newArraySize+= 1;
    int[] newArray = new int[newArraySize];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if(arr.Length % 2 == 1) newArray[newArraySize - 1] = arr[arr.Length / 2];
    return newArray;  
}

int[] array = CreateArrayRndInt(7, 0, 10);
PrintArray(array);
int[] newArr = NewArray(array);
PrintArray(newArr);

