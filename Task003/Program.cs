/*
Задача 2: Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/

// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
 
int[] arr = GetArray(5, 1 , 5);
Console.WriteLine($"Дан массив: [{String.Join(",", arr)}]");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

bool da = false;
foreach(int el in arr) if (el == number) da = true;

if (da == true) Console.WriteLine("Такое число в массиве есть");
else Console.WriteLine("Такого числа в массиве нет");




/*
Не мое решение

int[] array = GetArray(5, 1, 33);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);
string result = "";

foreach (int el in array){
    result = el == number ? "Да" : "Нет";
}

Console.WriteLine(result);

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/