// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
Console.Clear();

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("");
}

int[,] GetRandomArray(int range)
{
    Console.WriteLine("Enter the number of rows: ");
    int rows = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int columns = Convert.ToInt16(Console.ReadLine());

    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result_array[i, j] = new Random().Next(range);
        }
    }
    return result_array;
}

int[,] SortDescendingArray(int[,] sortedArray)
{
    for (int i = 0; i < sortedArray.GetLength(0); i++)
    {
        int sortedSize = 0;
        while (sortedSize < sortedArray.GetLength(1) - 1)
        {
            for (int j = 0; j < sortedArray.GetLength(1) - 1; j++)
            {
                if (sortedArray[i, j] < sortedArray[i, j + 1])
                {
                    int swap = sortedArray[i, j];
                    sortedArray[i, j] = sortedArray[i, j + 1];
                    sortedArray[i, j + 1] = swap;
                }
            }
            sortedSize++;
        }
    }
    return sortedArray;
}

// int[,] matrix1 = GetRandomArray(100);
// PrintMatrix(matrix1);
// SortDescendingArray(matrix1);
// PrintMatrix(matrix1);



// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FindMinSumRow(int[,] array)
{
    int minSum = int.MaxValue;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        Console.WriteLine($"row {i + 1}: {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            result = i;
        }
    }
    Console.WriteLine($"The row with minimal sum of numbers is #{result + 1}.");
}

// int[,] matrix2 = GetRandomArray(10);
// PrintMatrix(matrix2);
// FindMinSumRow(matrix2);



// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.

int[,,] Unique3DArray(int size)
{
    int elems = 1;
    Random rnd = new Random();
    int multiplier = rnd.Next(5, 10);
    Console.WriteLine("Multiplier is " + multiplier);
    Console.WriteLine();
    int[,,] array3D = new int[size, size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int v = 0; v < size; v++)
            {
                array3D[i, j, v] = multiplier + multiplier * elems;
                elems++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int v = 0; v < array.GetLength(2); v++)
            {
                Console.Write(array[i, j, v] + $"({i},{j},{v}) ");
            }
            Console.WriteLine("");
        }
    }
}

// Print3DArray(Unique3DArray(2));



// Задача 4: Заполните спирально массив 4 на 4.

int[,] FillSpiralArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int filler = 1;
        int coil_num = 0;
        FillSpiralBorders(array, ref coil_num, ref filler);
        return array;
    }
    else
    {
        Console.WriteLine("Cannot fill non-square array.");
        return array;
    }
}

int[,] FillSpiralBorders(int[,] borderArray, ref int coil_num, ref int filler)
{
    for (int i = coil_num; i < borderArray.GetLength(1) - coil_num; i++)
    {
        borderArray[coil_num, i] = filler;
        filler++;
    }
    for (int i = 1 + coil_num; i < borderArray.GetLength(0) - coil_num; i++)
    {
        borderArray[i, borderArray.GetLength(1) - 1 - coil_num] = filler;
        filler++;
    }
    for (int i = borderArray.GetLength(1) - 2 - coil_num; i > coil_num; i--)
    {
        borderArray[borderArray.GetLength(0) - 1 - coil_num, i] = filler;
        filler++;
    }
    for (int i = borderArray.GetLength(0) - 1 - coil_num; i > coil_num; i--)
    {
        borderArray[i, coil_num] = filler;
        filler++;
    }
    coil_num++;
    if (borderArray.GetLength(0) - coil_num * 2 > 0) return FillSpiralBorders(borderArray, ref coil_num, ref filler);
    else return borderArray;
}

int[,] spiralMatrix = new int[4, 4];
PrintMatrix(FillSpiralArray(spiralMatrix));