// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void weekend (int numb)
{
    if (numb > 5)
    {
        Console.WriteLine ("Yes, it is a weekend.");
    }
    else
    {
        Console.WriteLine ("No, it is not a weekend.");
    }
}

Console.WriteLine ("Enter the number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
{
    weekend(number);
}
else
{
    Console.WriteLine("Oops, there is a mistake! Enter the number from 1 to 7. ");
}