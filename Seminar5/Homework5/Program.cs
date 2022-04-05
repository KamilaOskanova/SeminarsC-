// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
Console.WriteLine("Enter the array length: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int count = 0;

for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");

    if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"\n{count}");
*/


// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
Console.WriteLine("Enter the array length: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int sum = 0;

for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
    if (i % 2 != 0) sum = sum + array[i];
}

Console.WriteLine($"\n{sum}");
*/


// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Enter the array length: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] array = new double[number];

for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(-333, 334);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double max = array[0];
double min = array[0];

for (int i = 0; i < number; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine($"The max number is {max}");
Console.WriteLine($"The min number is {min}");
Console.WriteLine($"The difference between max and min is {max - min}");