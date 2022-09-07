// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void ShowSecondDigit(int num) {
    string str = Convert.ToString(num);
    Console.WriteLine("Вторая цифра " + str[1]); 
};
ShowSecondDigit(456);
ShowSecondDigit(782);
ShowSecondDigit(918);