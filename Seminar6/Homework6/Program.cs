// Задача 1: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
void Positive(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"Enter the {i} number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    Console.WriteLine($"There are {count} positive numbers.");
}

Console.WriteLine("Enter the number: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length < 0 ) Console.WriteLine("Oops, try again.");

Positive(length);
*/


// Задача 2: 
// Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, 
// а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void FillArray(int rw, int cl)
{
    int[,] array = new int[rw, cl];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 || i == rw - 1 || j == 0 || j == cl - 1)
            {
                array[i, j] = 1;
                Console.Write(array[i, j] + " ");
            }
            else
            {
                array[i, j] = 0;
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns in the array: ");
int col = Convert.ToInt32(Console.ReadLine());

FillArray(rows, col);