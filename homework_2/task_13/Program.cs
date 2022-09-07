// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ShowThirdDigit(int num) {
    string sNum = Convert.ToString(num);
    if (sNum.Length < 3) Console.WriteLine($"У числа {sNum} нет третьей цифры"); 
    else Console.WriteLine($"Третья цифра числа {sNum} - это {sNum[2]}"); 
};
ShowThirdDigit(645);
ShowThirdDigit(78);
ShowThirdDigit(32679);