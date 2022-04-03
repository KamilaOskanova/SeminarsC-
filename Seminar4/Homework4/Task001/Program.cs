// Задача 1: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int number, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * number;
    }
    return result;
}

Console.WriteLine("Введите число, которое хотите возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0) Console.WriteLine($"Число {a} в степени {b} равно {Power(a, b)} ");
else Console.WriteLine("Ваша степень должна быть натуральным числом. ");