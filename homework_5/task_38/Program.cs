// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)  {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
        // System.Console.Write(array[i] + " ");
    }
    return array;
}

double[] aRandom = FillArray(10);
Console.WriteLine($"Сгенерированный массив [{String.Join("; ", aRandom)}]");

double GetDiff(double[] aDoubles){
    double diff = 0;
    double max = aDoubles[0];
    double min = aDoubles[0];
    for (int i = 1; i < aDoubles.Length; i++)
    {
       if (aDoubles[i] > max) {
            max = aDoubles[i];
        }
        if (aDoubles[i] < min) {
            min = aDoubles[i];
        }
    }
    System.Console.WriteLine($"Максимальный элемент = {max}, минимальный элемент = {min}");
    diff = max - min;
    return Math.Round(diff, 2);
}
Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + GetDiff(aRandom));