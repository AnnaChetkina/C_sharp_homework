// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(1, 10);
        }
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

void GetElem(int i, int j, int[,] arr){
    // System.Console.WriteLine($"{arr.GetLength(0)}, {arr.GetLength(1)} , {i}, {j}");
    if (i >= arr.GetLength(0) || j >= arr.GetLength(1)) System.Console.WriteLine("Такого числа в массиве нет");
    else System.Console.WriteLine($"Значение элемента на позиции [{i}, {j}] = {arr[i, j]}");
}

int[,] array = FillMas(4, 4);
PrintArray(array);
GetElem(1, 1, array);
System.Console.WriteLine();
GetElem(5, 5, array);
System.Console.WriteLine();