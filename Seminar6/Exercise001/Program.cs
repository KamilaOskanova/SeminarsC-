// Задача 1:
// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// A < B + C
/*
void Triangle(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b)) Console.WriteLine("Yes, this triangle exists.");
    else Console.WriteLine("No, this triangle doesn't exist.");
}


Console.WriteLine("Enter the first number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int numC = Convert.ToInt32(Console.ReadLine());

Triangle(numA,numB,numC);
*/


// Задача 2:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
void Binary(int a)
{
    string answer = "";
    while (a > 0)
    {
        answer = Convert.ToString(a % 2) + answer;
        a = a / 2;
    }
    Console.WriteLine(answer);
}

Console.WriteLine("Enter the number to convert: ");
int number = Convert.ToInt32(Console.ReadLine());
Binary(number);
*/

// Задача 3:
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
/*
void Fibonacci(int numA)
{
    int[] array = new int[numA];
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]} {array[1]} ");

    for (int i = 2; i < numA; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Fibonacci(number);
*/

/*
// Method 2
void Fib_Bruteforce(int size)
{
    int n1 = 0;
    int n2 = 1;
    int n;
    Console.Write(n1 + " " + n2 + " ");
    for (int i = 2; i < size; i++)
    {
        n = n1 + n2;
        n1 = n2;
        n2 = n;
        Console.Write(n + " ");
    }
}
Console.WriteLine("Enter  number:  ");
int N = Convert.ToInt32(Console.ReadLine());
Fib_Bruteforce(N);
*/

// Задача 4:
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[,] matrix = new int [3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

// можно также добавить getLength(...)

/* Method 2 - added copying an array
int [,] init_array = new int[3,4];
for (int i=0; i<init_array.GetLength(0);i++)
{
    for (int j=0; j<init_array.GetLength(1);j++)
        {
            init_array[i,j]=new Random().Next(100);
            Console.Write(init_array[i,j]+" ");
        }
    Console.WriteLine(" ");        
}

Console.WriteLine("----------------------------------");
int [,] array_copy = new int[init_array.GetLength(0),init_array.GetLength(1)];


for (int i=0; i<array_copy.GetLength(0);i++)
{
    for (int j=0; j<array_copy.GetLength(1);j++)
        {
            array_copy[i,j]=init_array[i,j];
            Console.Write(array_copy[i,j]+" ");
        }
    Console.WriteLine(" ");        
}
*/