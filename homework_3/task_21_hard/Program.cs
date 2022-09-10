// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.Write("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());
int[] aCoordinateX = new int[N];
int[] aCoordinateY = new int[N];

for (int i = 0; i < N; i++){
    Console.Write($"Введите координату X{i + 1} ");
    aCoordinateX[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату Y{i + 1} ");
    aCoordinateY[i] = Convert.ToInt32(Console.ReadLine());
}

double getDistance(int[] arrX, int[] arrY){
    int sqr = 0;
    for (int i = 0; i < arrX.Length; i++){
        sqr = sqr + (arrX[i] - arrY[i]) * (arrX[i] - arrY[i]);
    }
    double result = Math.Sqrt(sqr);
    return result;
}
Console.Write($"Растояние в {N}-мерном пространстве = ");
Console.WriteLine(getDistance(aCoordinateX, aCoordinateY));
// X (3,6,8); Y (2,1,-7), -> 15.84
// X (3, 6, 8, 10) Y(2, 1, -7, -8); -> 23,979157616563597