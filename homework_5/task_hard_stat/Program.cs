// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(1, 100);
    return array;
}

void FindAll2(int[] array){
    double[] result = new double[5]; 
    result[0] = array[0]; // max
    result[1] = 0; // maxInd
    result[2] = array[0]; // min
    result[3] = 0; // minInd
    result[4] = array[0]; // avg
    for (int i = 1; i < array.Length; i++){
        if (array[i] > result[0]) {
            result[0] = array[i];
            result[1] = i;
        }
        if (array[i] < result[2]) {
            result[2] = array[i];
            result[3] = i;
        }
        result[4] += array[i]; // todo ?
        // System.Console.WriteLine("avg =" + result[4]);
    }
    result[4] = result[4]/array.Length;
    Console.WriteLine($"max = {result[0]}, maxInd = {result[1]}, min = {result[2]}, minInd = {result[3]}, avg = {result[4]}");
}

double FindMedian(int[] array) {
    double median;
    SelectionSortMin(array);
    Console.WriteLine($"Отсортированный массив [{String.Join(", ", array)}]");
    if (array.Length % 2 == 1) median = array[array.Length/2];  
    else median = (array[array.Length/2 - 1] + array[array.Length/2]) / 2;
    System.Console.WriteLine($"{array[array.Length/2 - 1]} , {array[array.Length/2]} ");
    // System.Console.WriteLine("median = " + median);
    return median;
}

void SelectionSortMin(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

int[] array = FillArray(10);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", array)}]");
FindAll2(array);
// FindMedian(array);
Console.WriteLine($" Median = {FindMedian(array)}");

// int[] array1 = FillArray(9);
// Console.WriteLine($"Сгенерированный массив [{String.Join(", ", array1)}]");
// FindAll2(array1);
// FindMedian(array1);
// Console.WriteLine($"Median = {FindMedian(array1)}");
