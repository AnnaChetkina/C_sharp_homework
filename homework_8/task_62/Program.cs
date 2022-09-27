// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int n)
{
    int initialVal = 1;
    int startCol = 0;
    int endCol = n - 1;
    int startRow = 0;
    int endRow = n - 1;
    int[,] arr = new int[n, n];
    while (startCol <= endCol && startRow <= endRow) {
        
        for (int i = startCol; i <= endCol; i++) 
        { 
            arr[startRow, i] = initialVal;
            initialVal++;
        }
        startRow++;

        for (int j = startRow; j <= endRow; j++) 
        { 
            arr[j, endCol] = initialVal;
            initialVal++;
        }
        endCol--;

        for (int k = endCol; k >= startCol; k--) 
        { 
            arr[endRow, k] = initialVal;
            initialVal++;
        }
        endRow--;

        for (int m = endRow; m >= startRow; m--) 
        { 
            arr[m, startCol] = initialVal;
            initialVal++;
        }
        startCol++;
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

int[,] arr = FillArray(4);
PrintArray(arr);
System.Console.WriteLine();
int[,] arr1 = FillArray(6);
PrintArray(arr1);

