// ** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();


int[,] array = new int[3, 4];
FillArray(array);
WriteLine("Исходный массив:");
PrintArray(array);
WriteLine();
SortRows(array);
WriteLine("Результат:");
PrintArray(array);

void SortRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, max]) max = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
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