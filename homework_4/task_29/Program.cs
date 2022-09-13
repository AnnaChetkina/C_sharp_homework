// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintArray(int N){
    int[] arr = new int[N];
    for (int j = 0; j < N; j++) {
        Console.Write($"Введите {j}-элемент массива ");
        arr[j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Итоговый массив [{String.Join(", ", arr)}]");
}
PrintArray(N);