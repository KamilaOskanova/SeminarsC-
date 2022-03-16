int number1;
int number2;

Console.WriteLine("Enter the first number: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
number2 = Convert.ToInt32(Console.ReadLine());

int squared_number2 = number2 * number2;

Console.WriteLine("Is the first number the square of the second number?");

if(number1 == squared_number2)
{
    Console.WriteLine("Yes, it is"); // cответствие квадрата второго числа первому числу
}
else
{
    Console.WriteLine("No, it is not");
}