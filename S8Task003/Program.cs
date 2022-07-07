// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9

// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0

// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console;
Clear();



int[,] arrayA = new int[3, 3];
FillArray(arrayA);
WriteLine("Матрица А:");
PrintArray(arrayA);
WriteLine();
int[,] arrayB = new int[3, 3];
FillArray(arrayB);
WriteLine("Матрица B:");
PrintArray(arrayB);
WriteLine();
if (arrayA.GetLength(1) != arrayB.GetLength(0)) WriteLine("Произведение невозможно, поменяйте количество строк или столбцов");
else
{
    WriteLine("Результат: ");
    PrintArray(MultiMatrix(arrayA, arrayB));
}



int[,] MultiMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }

        }
    }

    return result;
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
