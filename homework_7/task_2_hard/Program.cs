// задача 2 HARD необязательная.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры),
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей.
// Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место 
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

void RandomArray(){
    
    Random rnd = new Random();
    int[] arr = new int[8];
    int val = 1;
    for (int k = 0; k < arr.Length; k++) arr[k] = val++;
   
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();

    for (int i = 0; i < arr.Length/2; i++)
    {
        
        int j = rnd.Next(i + 1, arr.Length);
            (arr[j], arr[i]) = (arr[i], arr[j]);
    }
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
RandomArray();



// var rnd = new Random();
// int[] a = Enumerable.Repeat(0, 1).Select(x => rnd.Next(0, 300)).ToArray();
// for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.Write($"{a[i]} ");
//     }