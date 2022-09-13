//Задача 26 HARD - необязательная: Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.
// 456 -> 3
// 0.78 -> 2
// 89.126 -> 5

string GetDigitsCount(double n) {
    int num = RemoveSeparator(n);
    int count = 0;

    while (num > 0) {
        num = num / 10;
        count++;
    }
    return $"Количество цифр в {n} = {count}";
}

int RemoveSeparator(double n){
    string str = n.ToString();
    str = str.Replace(",", "");
    int res = Convert.ToInt32(str);    
    return res;
}

Console.WriteLine(GetDigitsCount(456.0));
Console.WriteLine(GetDigitsCount(0.78));
Console.WriteLine(GetDigitsCount(89.126));

