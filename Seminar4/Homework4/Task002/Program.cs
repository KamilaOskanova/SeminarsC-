// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        int ostatok = 0;
        ostatok = a % 10;
        a = a / 10;
        sum = sum + ostatok;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0) Console.WriteLine($"Сумма цифр в числе {numberA} равна {DigitSum(numberA)}");
else Console.WriteLine("Вы ввели ненатуральное число. Попробуйте еще раз!");