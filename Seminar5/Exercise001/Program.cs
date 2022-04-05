// Задача 1: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] array = new int[12];
int positive = 0;
int negative = 0;

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] > 0) positive = positive + array[i];
    else negative = negative + array[i];
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов равна {positive}");
Console.WriteLine($"Сумма отрицательных элементов равна {negative}");
*/
// переделать задачу и сделать с фунцкциями


// Задача 2:
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
/*
int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.Write(array[i] * (-1) + " ");
}
*/
// переделать задачу и запросить у пользователя длину массива и добавить функции

// Задача 3:
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
/*
int[] array = new int[15];
int tumbler = 0; 
for (int i = 0; i < 15; i++)
{
    array[i] = new Random().Next(1, 21);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 15; i++)
{
    if (array[i] == number) 
    {
        Console.WriteLine ("Yes, this number is in the array.");
        tumbler = 1;
        break;
    }
}

if(tumbler == 0) Console.WriteLine ("No, this number is not in the array.");
*/

// Задача 4:
// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] array = new int[123];
int count = 0; 
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 1000);
    if(array[i] < 100 && array[i] > 9) count++;
}
Console.WriteLine(count);
*/
// Задача 5:
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Enter the array length: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

int length = 1;
if (number % 2 == 0) length = 0;
int[] array2 = new int[(number/2)+length];

for (int i = 0; i < number; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < (number / 2) + length; i++)
{
    array2[i] = array[i] * array[number - i - 1];
    if (i == number - i - 1) array2[i] = array[i];
    Console.Write(array2[i] + " ");
}