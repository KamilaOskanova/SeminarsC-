// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double GetCubes (int a)
{
    int index = 1;
    double cube1 = 1;
    while (index <= a)
    {
        cube1 = Math.Pow(index, 3);
        Console.Write(" " + cube1 + " ");
        index++;
    }
    return cube1;
}


Console.WriteLine ("Enter the natural number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb <= 0)
{
    Console.WriteLine("Try again! You can only enter the numbers more than zero. ");
}
else
{
    GetCubes(numb);
}