// задача 2 HARD необязательная.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры),
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей.
// Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место 
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    if ((n * m) % 2 == 1) {
        System.Console.WriteLine($"Не получиться сгенерировать массив с четным количеством символов {(n * m) % 2}");
        // throw new ArgumentException("Не получиться сгенерировать массив с четным количеством символов");
    } else {
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mas[i, j] = new Random().Next(1, 10);
            }
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
// int[,] arr = FillMas(1,2);
// PrintArray(arr);

void RandomArray(){
    int[] arr = new int[8];
    arr[0] = 1;
    arr[1] = 2;
    arr[2] = 3;
    arr[3] = 4;
    arr[4] = 5;
    arr[5] = 6;
    arr[6] = 7;
    arr[7] = 8;
    int[] arrJ = new int[arr.Length/2];
//    var rnd = new Random();
// int[] arrJ = Enumerable.Repeat(0, 10).Select(x => rnd.Next(0, 100)).ToArray();

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length/2; i++)
    {
        
        int j = new Random().Next(arr.Length/2 + i, arr.Length);
        arrJ[i] = j;
        System.Console.WriteLine($"i = {i} ,arrJ[i] = {arrJ[i]}");
        // обменять значения arr[j] и arr[i]
            // int temp = arr[j];
            // arr[j] = arr[i];
            // arr[i] = temp;
            // if ()
            (arr[j], arr[i]) = (arr[i], arr[j]);
    }
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
RandomArray();



// using System.Linq;
var rnd = new Random();
int[] a = Enumerable.Repeat(0, 1).Select(x => rnd.Next(0, 300)).ToArray();
// int a1 = Enumerable.Repeat(0, 10).Select(x => rnd.Next(0, 100));
// int a2 = Enumerable.Repeat(0, 10).Select(x => rnd.Next(0, 100));
// int a3 = Enumerable.Repeat(0, 10).Select(x => rnd.Next(0, 100));
// System.Console.WriteLine($"{a1}, {a2}, {a3}");
for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i]} ");
    }