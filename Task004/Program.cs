﻿/*
Задача 3: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5

*/



// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(123, 10, 200);

Console.WriteLine($"[{String.Join(",", array)}]");

int sum = 0;

foreach(int el in array)
{
    sum += (el >=10 && el <= 99) ? 1 : 0;
}
 Console.WriteLine($"Количество совпадений {sum}");
