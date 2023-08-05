/*
Задача 1: Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] some = GetArray(4, -8, 8);

Console.WriteLine($"[{String.Join(",", some)}]");

for (int i = 0; i < some.Length; i++)
{
    some[i] *=(-1);
}

Console.WriteLine($"[{String.Join(",", some)}]");



// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}