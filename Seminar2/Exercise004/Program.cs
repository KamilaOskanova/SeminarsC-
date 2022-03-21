// Напишите программу, которая принимает на вход число, а затем еще два числа,
// и проверяет, кратно ли первое число двум другим.

void multiple(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Yes, " + num1 + " is multiple of " + num2 + ", " + num3);
    }
    else
    {
        Console.WriteLine("No, " + num1 + " is not multiple of " + num2 + ", " + num3);
    }
}

Console.WriteLine( "Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

multiple (number1, number2, number3);