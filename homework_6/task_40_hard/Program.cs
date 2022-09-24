// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить, является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

void CheckTriangle(int a, int b, int c) {
    if (a < (b + c) & b < (a + c) & c < (a + b)) {
        System.Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
        GetTriangleInfo(a, b, c);
    }
    else System.Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
}
void GetTriangleInfo(int a, int b, int c) {
    double p = a + b + c; // периметр
    double sqr = Math.Round(Math.Sqrt((p/2) * (p/2 - a) * (p/2 - b) * (p/2 - c)), 3);
    double alfa = GetAngle(a, b, c, "alfa"); 
    double beta = GetAngle(a, b, c, "beta"); 
    double gamma = Math.Round(180 - alfa - beta, 2);
    System.Console.WriteLine($"Петиметр = {p}, Площадь = {sqr}, угол Альфа = {alfa} градусов, угол Бета = {beta} градусов, угол Гамма = {gamma} градусов");

    if (a == b & a == c) System.Console.WriteLine("Треугольник равносторонний");
    else System.Console.WriteLine("Треугольник не равносторонний");

    if ((a == b & a != c) || (c == b & c != a) || (c == a & c != b)) System.Console.WriteLine("Треугольник равнобедренный");
    else System.Console.WriteLine("Треугольник не равнобедренный");

    if (alfa == 90 || beta == 90 || gamma == 90) System.Console.WriteLine("Треугольник прямоугольный");
    else System.Console.WriteLine("Треугольник не прямоугольный");
}
double GetAngle(int a, int b, int c, string angle) {
    double cos;
     switch (angle)
    {
        case "alfa":
            cos = (Math.Pow(a,2.0) + Math.Pow(c,2.0) - Math.Pow(b,2.0))/(2*a*c);
            return  Math.Round(Math.Acos(cos) * 180/Math.PI, 2);
        case "beta":
            cos = (Math.Pow(a,2.0) + Math.Pow(b,2.0) - Math.Pow(c,2.0))/(2*a*b);
            return  Math.Round(Math.Acos(cos) * 180/Math.PI, 2);
        default:
            Console.WriteLine("Введенное число не соответствует дню недели");
            return 0;
    }
}

CheckTriangle(1, 3, 5);
System.Console.WriteLine();
CheckTriangle(10, 13, 15);
System.Console.WriteLine();
CheckTriangle(10, 10, 10);