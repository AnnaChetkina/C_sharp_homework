// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

try {
    Console.Write("Введите число 1: ");
    int x1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите число 2: ");
    int x2 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите число 3: ");
    int x3 = Convert.ToInt32(Console.ReadLine()); 
    int max = x1;

    if (x2 > max) {
        max = x2;
    }
    if (x3 > max) {
        max = x3;
    }
    
    Console.WriteLine("Максимальное число = " + max);

} catch {
    Console.WriteLine("Введено некорректное значение");
}