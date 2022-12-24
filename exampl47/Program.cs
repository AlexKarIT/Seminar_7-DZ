/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Объявление массива
int m = 3;
int n = 4;
double[,] array1 = new double[m, n];

Console.WriteLine("Введите максимальное значение которое может принять элемент массива :");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение которое может принять элемент массива :");
int minValue = Convert.ToInt32(Console.ReadLine());

//Заполнение массива

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array1[i, j] = Convert.ToDouble(new Random().Next(minValue * 10, (maxValue + 1) * 10));
        array1[i, j] /= 10;
    }
}


//Симпотичный вывод массива

void Printmatrix (double [,] inputMatrix)
{
Console.WriteLine();
Console.WriteLine("Полученный массив :");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        String text = Convert.ToString(array1[i, j]);
        int L = text.Length;
        Console.Write(" |" + new string(' ', 5 - L) + array1[i, j]);
    }
    Console.WriteLine();
    Console.WriteLine(new string('-', n * 7));
}

}

Printmatrix (array1);