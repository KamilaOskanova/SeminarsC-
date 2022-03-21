// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.

void multiple(int num1, int num2)
{
    // дополнительная команда при условии, что второе число больше первого
    if (num1 < num2)
    {
        int a = num1;
        num1 = num2;
        num2 = a;
    }

    if (num1 % num2 == 0)
    {
        Console.WriteLine(" Yes, " + num1 + " is multiple of " + num2);
    }
    else
    // я забыла вывести остаток от деления
    {
        Console.WriteLine(" No, " + num1 + " is not multiple of " + num2);
    }   
}

Console.WriteLine( "Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

multiple (number1, number2);