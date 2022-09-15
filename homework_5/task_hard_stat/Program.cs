// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.
int[] FillArray(int size) {
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(1, 100);
    return array;
}
void FindSomeValues(int[] array){
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
        result[4] += array[i]; 
    }
    result[4] = result[4]/array.Length;
    Console.WriteLine($"Максимальный элемент = {result[0]}, его индекс = {result[1]},");
    Console.WriteLine($"минимальный элемент = {result[2]}, его индекс  = {result[3]},");
    Console.WriteLine($"среднее арифметическое всех элементов = {result[4]}");
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

double FindMedian(int[] array) {
    double median;
    SelectionSortMin(array);
    Console.WriteLine($"Отсортированный массив [{String.Join(", ", array)}]");
    // если длина массива не четная, то медиана равна среднему элементу
    if (array.Length % 2 == 1) median = array[array.Length/2]; 
    // если длина массива четная, то медиана равна сумме двух средних элементов, деленных пополам
    else median = (array[array.Length/2 - 1] + array[array.Length/2]) / 2.0; 
    return median;
}

int[] array = FillArray(10); // длина массива четная
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", array)}]");
FindSomeValues(array);
Console.WriteLine($"Медианное значение = {FindMedian(array)}");

int[] array1 = FillArray(7); // длина массива не четная
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", array1)}]");
FindSomeValues(array1);
Console.WriteLine($"Медианное значение = {FindMedian(array1)}");
