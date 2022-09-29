// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArr3D(int a, int b, int c){
    int[] tempArr = new int[a * b * c];
    int[,,] arr3D = new int[a, b, c];
    Random rnd = new Random();

    for (int i = 0; i < tempArr.Length; i++){
        tempArr[i] = rnd.Next(10, 100);
        if (i > 0) {
            for (int j = 0; j < i; j++) {
                while (tempArr[i] == tempArr[j]) {
                    tempArr[i] = rnd.Next(10, 100);
                    j = 0;
                } 
            }
        }
        // System.Console.WriteLine($"tempArr[{i}] = {tempArr[i]}");
    }
    int z = 0;
    for (int n = 0; n < a; n++)
            {
                for (int m = 0; m < b; m++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        arr3D[n, m, k] = tempArr[z];
                        z++;
                        System.Console.Write($"{arr3D[n, m, k]}({n}, {m}, {k}) ");
                    }
                    System.Console.WriteLine();
                }
            }   
} 

FillArr3D(2, 2, 2);