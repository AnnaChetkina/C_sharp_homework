// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 11);
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

int[] GetSingleArray(int[,] arr){
            int[] m1 = new int[arr.GetLength(0) * arr.GetLength(1)];
            int z = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    m1[z] = arr[i, j];
                    z++;
                }
    return m1;
}

void PrintSingleArray(int[] mmm)
{

    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }

}


int[] SelectionSortMin(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
    return array;
}


int[,] SingleToArray(int[] m1, int n, int m){
            int[,] m2 = new int[n, m];
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    m2[i, j] = m1[z];
                    z++;
                }
            }   
    return m2;
}
int[,] arr1 = FillMas(2, 4);
PrintArray(arr1);
System.Console.WriteLine();
// PrintSingleArray(GetSingleArray(arr1));
int[] singleArr = GetSingleArray(arr1);
PrintSingleArray(SelectionSortMin(singleArr));
System.Console.WriteLine();
PrintArray(SingleToArray(singleArr, arr1.GetLength(0), arr1.GetLength(1)));
