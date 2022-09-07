// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа.

void DeleteSecondDigit(int num) {
    num = Math.Abs(num);
    string sNum = Convert.ToString(num);
    if (sNum.Length < 2) Console.WriteLine($"У числа {sNum} нельзя удалить вторую цифру"); 
    else Console.WriteLine($"Старое число {sNum}. Новое число {sNum.Remove(1, 1)}"); 
};
DeleteSecondDigit(4545656);
DeleteSecondDigit(-7862);
DeleteSecondDigit(91);
DeleteSecondDigit(8);



