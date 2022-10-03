// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int M, int N)
{
    if (N < M) return 0;
    return M + SumRec(M + 1, N);
}
Console.WriteLine(SumRec(1, 15));
Console.WriteLine(SumRec(4, 8));
