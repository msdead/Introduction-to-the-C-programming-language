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

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == numb) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(10, 0, 100);
PrintArray(array);
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданное число присутствует в массиве?");
Console.WriteLine(FindNumberArray(array, number) ? "Да" : "Нет");