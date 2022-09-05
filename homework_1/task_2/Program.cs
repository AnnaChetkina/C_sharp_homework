// Задача 2 - Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
try{
    Console.Write("Введите число 1: ");
    double x1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Введите число 2: ");
    double x2 = Convert.ToDouble(Console.ReadLine()); 

    if (x1 > x2) {
        Console.WriteLine("Большее число = " + x1);
        Console.WriteLine("Меньшее число = " + x2);
    } else {
        Console.WriteLine("Большее число = " + x2);
        Console.WriteLine("Меньшее число = " + x1);
    }
} catch {
    Console.WriteLine("Введено некорректное значение");
}


