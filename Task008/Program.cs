/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
    Console.WriteLine($"[{string.Join(" ", arr)}]");
    return arr;
}

//Метод, который возвращает сумму элементов на нечётных индексах:

int SumOddIndexEl(int[] array)
{
    int size = array.Length;
    int sumEl = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sumEl += array[i];
    }
    return sumEl;
}


//Сама программа:

int[] mas = GiveMas();
Console.WriteLine($"Сумма элементов, находящихся на нечётных индексах равна: {SumOddIndexEl(mas)}");