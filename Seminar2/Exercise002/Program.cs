// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int Delete2Digit (int num)
{
    int n1 = num / 100 * 10;
    int n2 = num % 10;
    return n1 + n2;
}

int number = new Random().Next(100, 999);
Console.WriteLine(number + " --> " + Delete2Digit(number));