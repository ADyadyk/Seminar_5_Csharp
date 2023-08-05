/*
Задача 4: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

//С чётным количеством элементов в исходном массиве

// Общий метод для создания одномерного массива
int[] GetArray(){
    Console.Write("Введите размер массива (чётное число): ");
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

int[] newArray = new int[array.Length/2];

for (int i = 0; i < (array.Length/2); i++)
{
    newArray[i] = array[i] * array[array.Length -1 - i];
}

Console.WriteLine($"[{String.Join(",", newArray)}]");







//Не мое решение


/*
Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

int[] haha = GetArray(6, 1, 10);
int[] hoho = new int[haha.Length / 2];
Console.Write($"[{String.Join(",", haha)}]");
for(int i = 0; i < (haha.Length / 2); i++){
    hoho[i] = haha[i] * haha[haha.Length - 1 - i];
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