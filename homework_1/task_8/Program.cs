// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

try {
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    int n1 = 2;

    while (n1 <= n) {
        Console.Write(n1 + ", ");
        n1 = n1 + 2;
    }
    
} catch {
    Console.WriteLine("Введено некорректное значение");
}