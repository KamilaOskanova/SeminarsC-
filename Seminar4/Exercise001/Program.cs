// Задача 1:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int Sum(int A)
{
    int result = 0;

    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

// $ - позволяет использовать методы и переменные для чтения программой
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число. Попробуйте еще раз!");
else Console.WriteLine($"Сумма чисел от 1 до {numA} равна {Sum(numA)}");
*/


// Задача 2:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void Length(int N)
{
    int l = 1;
    while (Math.Abs(N / 10) >= 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в введенном числе " + l);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Length(number);
*/


// Задача 3:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int A)
{
    int result = 1;

    int i = 1;
    while (i <= A)
    {
        result = result * i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

// $ - позволяет использовать методы и переменные для чтения программой
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число. Попробуйте еще раз!");
else Console.WriteLine($"Произведение чисел от 1 до {numA} равно {Factorial(numA)}");
*/


// Задача 4:
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void bitArray()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,2); // Входят только 0 и 1, в методе отмечает 0 и 2
        Console.Write(a[i] + " ");
    }
}

bitArray();