// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string getSqr2(int num) {
    string s = "";
    int i = 1;
    while (i <= num) {
        s = s + Math.Pow(i, 3) + " ";
        i++;
    }
    return s;
};

Console.WriteLine(getSqr2(3));
Console.WriteLine(getSqr2(5));