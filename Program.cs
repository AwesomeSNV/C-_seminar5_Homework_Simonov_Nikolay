// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*int[] array = GetArray(12, 99, 1000);
Console.WriteLine(String.Join(" ", array));

int Count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Count = Count + 1;
    }
}

Console.WriteLine($"Количество четных чисел в массиве равняется: {Count}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] array = GetArray(4, -1000, 1000);
// Console.WriteLine(String.Join(" ", array));

// int NegativeSum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         NegativeSum += array[i];
//     }
// }

// Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в массие равняется : {NegativeSum}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return res;
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = GetArray(5, 0, 100);
Console.WriteLine(String.Join(" ", array));

int max = 0;
int min = 0;

for (int i = 0; i < array.Length; i++)
    {
    int minPosition = i;
    for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            { 
                minPosition = j;
                min = array[j];
            }
        }
    if (array[i] > max)
        {
            max = array[i];
        }
    }

int result = max - min;

Console.WriteLine($"Максимальное число массива: {max}, минимальное число массива {min}, разница между максимальным и минимальным элементом массива равна: {result}.");

int[] GetArray(int size, int minValue, int maxValue)
    {
        int[] res = new int[size];

        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(minValue, maxValue +1);
        }
        return res;
    }