/*Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int value = 2;

while(value <= number)
{
    Console.Write(value + " ");
    value +=2;
}

if (number <= 1)
{
    Console.WriteLine("Пожалуйста, введите число больше 1");
}