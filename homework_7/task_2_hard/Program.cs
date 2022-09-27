// задача 2 HARD необязательная.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры),
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей.
// Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место 
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

int[,] RandomArray(){
    
    int[,] arr = new int[,] 
    {
        {1, 2, 3, 4, 1, 2, 3, 4},
        {1, 2, 3, 4, 1, 2, 3, 4},
        {1, 2, 3, 4, 1, 2, 3, 4}
    };
    // int[] arr = new int[8];
    // int val = 1;
    // for (int k = 0; k < arr.Length; k++) arr[k] = val++;
   
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     System.Console.Write($"{arr[i]} ");
    // }
    // System.Console.WriteLine();
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0)/2; i++)
    {
        // System.Console.WriteLine($"{i} ");
        int k = rnd.Next(arr.GetLength(0)/2, arr.GetLength(0));
        // System.Console.WriteLine($"{k} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        (arr[i, j], arr[k, j]) = (arr[k, j], arr[i, j]);
    }
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     System.Console.Write($"{arr[i]} ");
    // }
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
PrintArray(RandomArray());



// var rnd = new Random();
// int[] a = Enumerable.Repeat(0, 1).Select(x => rnd.Next(0, 300)).ToArray();
// for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.Write($"{a[i]} ");
//     }