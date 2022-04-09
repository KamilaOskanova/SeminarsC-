// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
void FillRandomDoubleTwoDimensionalArray(int rows, int columns)
{
    double[,] matrix = new double[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99, 100) / 10.0;
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

FillRandomDoubleTwoDimensionalArray(m, n);
*/


// Задача 2. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

/*
int[,] PrintTwoDimentsionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void FindElementInArray(int[,] matrix, int rowindex, int columnindex)
{
    int element = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == rowindex && j == columnindex) element = matrix[i, j];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The element with index ({rowindex}, {columnindex}) is {element}.");
}


Console.WriteLine("Enter the array's number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the array's number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the element's row number: ");
int rowind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the element's column number: ");
int colind = Convert.ToInt32(Console.ReadLine());

int[,] array_result = new int[m, n];

PrintTwoDimentsionalArray(array_result);
if (rowind < array_result.GetLength(0) && colind < array_result.GetLength(1))
{
    FindElementInArray(array_result, rowind, colind);
}
else 
{
    Console.WriteLine();
    Console.WriteLine($"Try again, the element with index ({rowind}, {colind}) is not in the array. ");
}
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.


int[,] PrintTwoDimentsionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 100);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void FindArrayColumnMean(int[,] matrix)
{
    Console.Write("The mean of elements in each column is ");
    double mean = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double columnsum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnsum = columnsum + matrix[i,j];
        }
        mean = Math.Round(columnsum / matrix.GetLength(0), 1);
        Console.Write(mean + " | ");
    }
}

Console.WriteLine("Enter the array's number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the array's number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array_result = new int[m,n];
PrintTwoDimentsionalArray(array_result);
FindArrayColumnMean(array_result);
