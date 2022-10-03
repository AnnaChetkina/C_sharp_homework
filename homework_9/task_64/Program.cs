// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int N)
{
    if (N == 1) return "1";
    // return Convert.ToString(N) + ", " + Convert.ToString(PrintNumbers(N - 1));
    return Convert.ToString(N) + ", " + PrintNumbers(N - 1);

}
Console.WriteLine(PrintNumbers(5));
Console.WriteLine(PrintNumbers(8));
