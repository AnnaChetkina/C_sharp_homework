// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++) mas[i, j] = new Random().Next(1, 10);
    }
    return mas;
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

void PrintColAvg(int[,] arr){
    double[] avgArr = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++) 
        {
            avgArr[i] += arr[j, i];
        }
        avgArr[i] = avgArr[i]/arr.GetLength(0);
    }
    System.Console.WriteLine();
    for (int k = 0; k < arr.GetLength(1); k++) 
        {
            System.Console.Write($"{avgArr[k]} ");            
        }
}

int[,] arr1 = FillArray(2, 4);
PrintArray(arr1);
PrintColAvg(arr1);
