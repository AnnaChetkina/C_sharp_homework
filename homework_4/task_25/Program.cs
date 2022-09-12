// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int a, int b){
    int degree = 1;
    for (int i = 1; i <= b; i++){
        degree *= a;
    }
    return degree;
}
Console.WriteLine($"3 в степени 5 = {GetDegree(3, 5)}");
Console.WriteLine($"2 в степени 4 = {GetDegree(2, 4)}");
Console.WriteLine($"5 в степени 5 = {GetDegree(5, 5)}");