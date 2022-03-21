//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int SecondDigit(int num)
{
    int n1 = (num / 100) * 100; 
    int n2 = num / 10 * 10;
    int result = (n2 - n1) / 10;
    return result;
}

Console.WriteLine( "Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());   

if( number >= 100 && number <= 1000 )
{
    Console.WriteLine(number + " --> " + SecondDigit(number));
}
else
{
    Console.WriteLine("Oops, there is a mistake! Try again");
}