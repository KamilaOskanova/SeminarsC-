// Задача 1:
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.
/*
Console.WriteLine("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] shifter = new int[m, n];

for (int i = 0; i < shifter.GetLength(0); i++)
{
    for (int j = 0; j < shifter.GetLength(1); j++)
    {
        shifter[i, j] = new Random().Next(-9, 10);
        Console.Write(shifter[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int j = 0; j < shifter.GetLength(1); j++)
{
    int temp = shifter[0, j];
    shifter[0, j] = shifter[m - 1, j];
    shifter[m - 1, j] = temp;
}

for (int i = 0; i < shifter.GetLength(0); i++)
{
    for (int j = 0; j < shifter.GetLength(1); j++)
    {
        Console.Write(shifter[i, j] + " ");
    }
    Console.WriteLine();
}
*/
// Задача 2:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Enter the matrix height and width: ");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, column];

if (row != column) Console.WriteLine("It is impossible! ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-9, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int temp = 0, count = 0;
for (int i = 0; i < row && count <= (row * column) / 2 + 1; i++)
{
    for (int j = i; j < column; j++)
    {
        temp = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = temp;
        count++;
    }
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
// Задача 3:
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых 
// расположен наименьший элемент.