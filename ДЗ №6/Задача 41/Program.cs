int[] CreateArrayRndInt(int size) // Метод создания массива
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int FindPositiveNumb(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write($"Введите какое количество чисел хотите использовать: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateArrayRndInt(size);
FindPositiveNumb(arr);
Console.WriteLine($"Количество ведённых чисел больше 0 : {FindPositiveNumb(arr)}");