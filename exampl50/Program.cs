/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите номер строки для поиска элемента массива от 1 до 9:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца для поиска элемента массива от 1 до 9:");
int Y = Convert.ToInt32(Console.ReadLine());


// Объявление массива случайным размером от 1 до 10

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);


double[,] array1 = new double[m, n];

//максимальное значение которое может принять элемент массива
int maxValue = 100;

//минимальное значение которое может принять элемент массива
int minValue = 0;

//Заполнение массива

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array1[i, j] = new Random().Next(minValue, (maxValue + 1));

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

void FindElement (double [,] array, int line, int column)
{
    if (line < array.GetLength(0) && column < array.GetLength(1)) Console.WriteLine($"Искомый элемент с индексом {line},{column}  :  {array[line,column]}");
    else Console.WriteLine($"Элемента с индексом {line},{column} нет");
}

FindElement(array1, X, Y);