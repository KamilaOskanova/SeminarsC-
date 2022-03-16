Console.Write("Enter the number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Monday");
    }
    if(number == 2)
    {
        Console.WriteLine("Tuesday");
    }
    if(number == 3)
    {
        Console.WriteLine("Wednesday");
    }
    if(number == 4)
    {
        Console.WriteLine("Thursday");
    }
    if(number == 5)
    {
        Console.WriteLine("Friday");
    }
    if(number == 6)
    {
        Console.WriteLine("Saturday");
    }
    if(number == 7)
    {
        Console.WriteLine("Sunday");
    }
}
else
{
    Console.WriteLine("This day of the week doesn't exist");
}
