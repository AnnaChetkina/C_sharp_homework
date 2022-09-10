// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string GetPolydrome(int num) {
    string res = "";
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n4 = num % 100 / 10;
    int n5 = num % 10;
    if (n1 == n5 & n2 == n4)  res = $"Число {num} является полиндромом";
    else res = $"Число {num} не является полиндромом";
    return res;
};
Console.WriteLine(GetPolydrome(14212));
Console.WriteLine(GetPolydrome(12821));
Console.WriteLine(GetPolydrome(23432));
Console.WriteLine(GetPolydrome(12345));