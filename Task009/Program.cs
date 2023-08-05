/*
Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76
*/

//Метод, который задаёт одномерный массив, заполненный случайными числами:

int[] GiveMas()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    Console.Write("Введите min element: ");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Введите max element: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine();
    Console.WriteLine("Полученный массив:");
    Console.WriteLine($"[{string.Join(" ", arr)}]");
    Console.WriteLine();
    return arr;
}

// Метод, который ищет максимальный и минимальный элементы и определяет разницу между ними:

void DiffMaxMin(int[] array)
{
    int size = array.Length;
    int IndMaxEl = 0;
    int IndMinEl = 0;

    if (array[0] < array[1]) IndMaxEl = 1;
    else IndMinEl = 1;

    for (int i = 1; i < (size-1); i++)
    {
        if (array[IndMaxEl] < array[i+1])
        {
            IndMaxEl = i + 1;
            if (array[i] < array[IndMinEl]) IndMinEl = i;
        }
        else 
        if (array[IndMinEl] > array[i+1]) IndMinEl = i+1;
    }
    Console.WriteLine($"Индекс минимального элемента массива равен min = {IndMinEl}.");
    Console.WriteLine($"Cам минимальный элемент равен minElement = {array[IndMinEl]}");
    Console.WriteLine();
    Console.WriteLine($"Индекс максимального элементо массива равен min = {IndMaxEl}.");
    Console.WriteLine($"Cам максимвльный элемент равен maxElement = {array[IndMaxEl]}");
    Console.WriteLine();
    int result = array[IndMaxEl] - array[IndMinEl];
    Console.WriteLine($"Разница между максимальным и минимальным элементами составляет: {result}");
}


//Сама программа:

int[] mas = GiveMas();
DiffMaxMin(mas);