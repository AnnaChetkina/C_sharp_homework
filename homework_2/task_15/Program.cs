//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void CheckWeekendDay(int nDay) {
    if (nDay == 6 | nDay == 7) Console.WriteLine("Выходной день"); 
    else Console.WriteLine("Не выходной день"); 
};
CheckWeekendDay(7);
CheckWeekendDay(6);
CheckWeekendDay(1);
