// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void Mult(int[,] m1, int[,] m2) {
// число столбцов первой матрицы равно числу строк второй, следовательно их произведение существует
    if (m1.GetLength(1) != m2.GetLength(0)) {
        System.Console.WriteLine("Невозможно найти произведение данных матриц");
    } else {
        int[,] matr = MultMatrix(m1, m2);
        PrintArray(matr);
    }
}

int[,] MultMatrix(int[,] m1, int[,] m2) {
// Число строк в матрице m1 - 2, число столбцов в матрице m2 - 2. 
// Следовательно, размерность матрицы C = AB - 2 X 2.
        int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];

        for (int i = 0; i < res.GetLength(0); i++) { // строки в новой матрице
            for (int j = 0; j < res.GetLength(1); j++) { // столбцы в новой матрице
                for (int k = 0; k < m2.GetLength(0); k++) 
                    res[i, j] = res[i, j] + m1[i, k] * m2[k, j];
            }
        }
        return res;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
int[,] a1 = {
    {2, 4},
    {3, 2}
};
int[,] b1 = {
    {3, 4},
    {3, 3}
};
Mult(a1, b1);
System.Console.WriteLine();
int[,] a2 = {
    {2, 1, 1},
    {3, 0, 1}
};
int[,] b2 = {
    {3, 1},
    {2, 1},
    {1, 0}
};

Mult(a2, b2);
System.Console.WriteLine();
int[,] a3 = {
    {2, 4},
    {3, 2}
};
int[,] b3 = {
    {3, 4, 4},
    {3, 3, 6},
    {3, 3, 6}
};

Mult(a3, b3);