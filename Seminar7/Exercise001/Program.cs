// Задача 1:
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
void NewRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99, 100);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
FillArray(m, n);
*/

// Задача 2: 
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
void SumIndexArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
SumIndexArray(m, n);
*/
// Задача 3: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
/*
void SquaredEvenIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
SquaredEvenIndex(m, n);
*/

// Задача 4:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.

void SumMainDiagonal(int rows)
{
    int[,] matrix = new int[rows, rows];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
            if (i == j) sum = matrix[i, j] + sum;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"The sum of the main diagonal elements is {sum}.");
}

Console.WriteLine("Enter the number of rows and columns: ");
int m = Convert.ToInt32(Console.ReadLine());

SumMainDiagonal(m);