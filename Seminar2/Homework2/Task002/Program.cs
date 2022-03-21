// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    int result = -1;
    while(num >= 1000)
    {
        num = num / 10;
    }
    if (num < 1000)
        {
            int n1 = num / 10 * 10;
            result = num - n1;
            return result;
        }
    return result;
}

Console.WriteLine( "Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());   

if( number >= 100 )
{
    Console.WriteLine(number + " --> " + ThirdDigit(number));
}
else
{
    Console.WriteLine("Oops, the number should have at least three digits! Try again");
}