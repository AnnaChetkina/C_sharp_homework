// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int CountPositiveDigits(){
    int count = 0;
    Console.Write("Сколько чисел вы хотите ввести? ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        Console.WriteLine($"Введите {i + 1}-е число ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine(CountPositiveDigits());