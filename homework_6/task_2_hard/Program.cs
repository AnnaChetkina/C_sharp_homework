// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
int[,] FillArray(int n, int m)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++) arr[i, j] = new Random().Next(0, 11);
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
void FindMaxMin(int[,] array){
    int max = array[0, 0]; 
    int[] maxInd = {0, 0}; 
    int min = array[0, 0]; 
    int[] minInd = {0, 0}; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) {
                max = array[i, j];
                maxInd[0] = i;
                maxInd[1] = j;
            }
            if (array[i, j] < min) {
                min = array[i, j];
                minInd[0] = i;
                minInd[1] = j;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент = {max}, его индекс = ({maxInd[0]}; {maxInd[1]}),");
    Console.WriteLine($"Минимальный элемент = {min}, его индекс = ({minInd[0]}; {minInd[1]}),");
}
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()); 

int[,] array = FillArray(n, m);
PrintArray(array);
FindMaxMin(array);
