//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int FindMaxNum(int num)
{
    int n1 = num % 10; // для отображения единиц - число 85 делим на 10, остаток 5 => n1 = 5
    int n2 = num / 10; // для отображения десятков - число 85 делим на 10, получаем 8 => n2 = 8

    if (n1 > n2)
    {
        return n1;
    }
    else 
    {
        return n2;
    }
}

int number = new Random().Next(10, 99);
Console.WriteLine("Current number is " + number + ", max part is " + FindMaxNum(number));