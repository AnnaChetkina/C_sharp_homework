// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetDigitsSum(int num){
    int sum = 0;
    int i = 0;
    int[] arr = new int[Convert.ToString(num).Length];
    int temp = 0;

    while (num > 0) {
        temp = num % 10;
        num = num / 10;
        arr[i] = temp;
        i++;
    }
    
    for (int j = 0; j < arr.Length; j++) sum += arr[j];
    return sum;
}
int n1 = 452, n2 = 82, n3 = 9012, n4 = 123;
Console.WriteLine($"Сумма цифр в числе {n1} = {GetDigitsSum(n1)}");
Console.WriteLine($"Сумма цифр в числе {n2} = {GetDigitsSum(n2)}");
Console.WriteLine($"Сумма цифр в числе {n3} = {GetDigitsSum(n3)}");
Console.WriteLine($"Сумма цифр в числе {n4} = {GetDigitsSum(n4)}");


