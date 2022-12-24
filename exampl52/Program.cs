/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6
*/

// Объявление массива
Console.WriteLine("Введите число строк массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива :");
int n = Convert.ToInt32(Console.ReadLine());

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
        array1[i, j] = new Random().Next(minValue, maxValue + 1);    
    }
}


//Симпотичный вывод массива

void Printmatrix (double [,] inputMatrix)
{
Console.WriteLine();
Console.WriteLine("Полученный массив :");

for (int i = 0; i < inputMatrix.GetLength(0); i++)
{
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        String text = Convert.ToString(inputMatrix[i, j]);
        int L = text.Length;
        Console.Write(" |" + new string(' ', 5 - L) + inputMatrix[i, j]);
    }
    Console.WriteLine();
    Console.WriteLine(new string('-', inputMatrix.GetLength(1) * 7));
}

}

// метод вычисления среднего в i столбце

double Average (double [,] inputMatrix, int column)
{
    double aver = 0;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        aver += inputMatrix [i, column];
    }
    aver /= inputMatrix.GetLength(1);
    return aver;
}


Printmatrix (array1);

double[,] array2 = new double[1, n];

for (int i = 0; i < array1.GetLength(1); i++)
{
   array2[0, i] = Average (array1, i);
}

Console.Write("Вычисляем средние значения по столбцам...");
Printmatrix (array2);