// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.

string GetPolydrome(int num) {
    String sNum = Convert.ToString(Math.Abs(num));
    bool isPolydrome = true;
    for (int i = 0; i < sNum.Length/2; i++)
    {
        if (sNum[i] != sNum[sNum.Length - 1 - i]) isPolydrome = false;
    }
    string res = isPolydrome == true ? $"Число {sNum} является полиндромом" : $"Число {num} не является полиндромом";
    return res;
};
Console.WriteLine(GetPolydrome(0142120));
Console.WriteLine(GetPolydrome(1221));
Console.WriteLine(GetPolydrome(234432));
Console.WriteLine(GetPolydrome(2344532));
Console.WriteLine(GetPolydrome(0));
Console.WriteLine(GetPolydrome(-33));
Console.WriteLine(GetPolydrome(1234554321));