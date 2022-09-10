// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double getDistance(int A1, int A2, int A3, int B1, int B2, int B3){
    double sqr = (B1 - A1)*(B1 - A1) + (B2 - A2)*(B2 - A2) + (B3 - A3)*(B3 - A3);
    double result = Math.Sqrt(sqr);
    return result;
}
double distance1 = getDistance(3, 6, 8, 2, 1, -7);
Console.WriteLine($"Расстояние между точками в 3D пространстве {distance1}");
double distance2 = getDistance(7, -5, 0, 1, -1, 9);
Console.WriteLine($"Расстояние между точками в 3D пространстве {distance2}");

