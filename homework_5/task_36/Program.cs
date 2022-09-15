// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)  array[i] = new Random().Next(-100, 100);
    return array;
}

int GetUnevenPosSum(int[] array){
    int sum = 0;
    for (int pos = 0; pos < array.Length; pos++){
        if (pos % 2 == 1) {
            sum = sum + array[pos];
            // System.Console.WriteLine(pos + " " + sum);
        }
    }
    return sum;
}

int[] aRandom = FillArray(20);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", aRandom)}]"); 
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetUnevenPosSum(aRandom)}");

