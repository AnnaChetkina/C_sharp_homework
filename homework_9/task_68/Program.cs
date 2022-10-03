// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FnAkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FnAkerman(m - 1, 1);
    if (m > 0 && n > 0) return FnAkerman(m - 1, FnAkerman(m, n - 1));
    else return 0;
}
Console.WriteLine(FnAkerman(2, 3)); // 9
Console.WriteLine(FnAkerman(3, 2)); // 29
Console.WriteLine(FnAkerman(2, 2)); // 7