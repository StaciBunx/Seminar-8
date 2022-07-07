// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
Clear();

int[,] array = new int[3, 4];
FillArray(array);
WriteLine("Исходный массив:");
PrintArray(array);
WriteLine();
WriteLine("Результат:");
PrintMinRow(GetEachRowSum(array));

int[] GetEachRowSum(int[,] arr)
{
    int[] rowSumArray = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i, j];
        }
        rowSumArray[i] = result;
    }
    return rowSumArray;

}

void PrintMinRow(int[] array)
{
    int i = 0;
    int minIndex = 0;
    int min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
        else continue;
    }
    WriteLine($"Строка номер {minIndex+1}");
}



void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Write($"{newArray[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
        }
    }
}
