
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int n)
{
    int[,] arr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++) arr[i, j] = new Random().Next(1, 10);
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

void GetMinRow(int[,] arr){
    int[] sumArr = new int[arr.GetLength(0)];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumArr[i] = sumArr[i] + arr[i, j];
        }
        // System.Console.WriteLine($"sumArr = {sumArr[i]}");
    }
    int minSum = sumArr[0];
    int minSumRow = 0;
    for (int k = 1; k < sumArr.Length; k++)
    {
        if (sumArr[k] < minSum) {
            minSum = sumArr[k];
            minSumRow = k;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}");
}
int[,] array = FillArray(4);
PrintArray(array);
GetMinRow(array);