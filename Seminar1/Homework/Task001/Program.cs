/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max, min;
if (number1 > number2)
{ 
    max = number1;
    Console.Write("Наибольшее число - ");
    Console.WriteLine(max);
    
    min = number2;
    Console.Write("Наименьшее число - ");
    Console.WriteLine(min);
}
else
{
    max = number2;
    Console.Write("Наибольшее число - ");
    Console.WriteLine(max);
    
    min = number1;
    Console.Write("Наименьшее число - ");
    Console.WriteLine(min);
}