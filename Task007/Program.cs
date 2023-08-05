/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Метод, который задаёт массив:

int[] GiveMas()
{
    Console.Write("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine($"[{String.Join(" ", arr)}]");
    return arr;
}

//Метод, который подсчитывает количнство чётных и нечётных чисел в массиве:

int EvenCount(int[] array)
{
    int sizeAr = array.Length;
    int countEven = 0;

    for (int i = 0; i < sizeAr; i++)
    {
        if (array[i]%2 == 0) countEven++;
    }
    return countEven;
}

//Сама программа

int[] mas = GiveMas();
Console.WriteLine($"Количество чётных элементов равно: {EvenCount(mas)}");
Console.WriteLine($"Количество нечётных элементов равно: {mas.Length - EvenCount(mas)}");