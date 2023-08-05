/*
Задача 4: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21


С проверкой на количество элементов (чётное или не чётное) если количество элементов нечётное
то средний элемент записываем в конец нового массива.
*/
// Общий метод для создания одномерного массива
int[] GetArray()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    Console.Write("Введите min element: ");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Введите max element: ");
    int maxValue = int.Parse(Console.ReadLine()!);
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


int[] array = GetArray();

Console.WriteLine($"[{String.Join(",", array)}]");

int size = array.Length/2;

if (array.Length % 2 != 0) size++;

int[] newArray = new int[size];


for (int i = 0; i < size; i++)
{
    newArray[i] = array[i] * array[array.Length -1 - i];
}

if (array.Length % 2 != 0)
{
    newArray[size-1] = array[array.Length/2];
}


Console.WriteLine($"[{String.Join(",", newArray)}]");



/*

НЕ МОЁ РЕШЕНИЕ


int[] haha = GetArray(7, 1, 10);
int size = haha.Length / 2;
if(haha.Length % 2 != 0) size++;
int[] hoho = new int[size];

Console.Write($"[{String.Join(",", haha)}]");
for(int i = 0; i < size; i++)
{
    hoho[i] = haha[i] * haha[haha.Length - 1 - i];
}
if(haha.Length % 2 != 0){
    hoho[size - 1] = haha[haha.Length / 2];
}
Console.Write($"[{String.Join(",", hoho)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/