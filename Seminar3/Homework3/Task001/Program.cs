// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindrome(int x)
{
    int a1 = x % 10;  
    int a2 = x / 10 % 10; 
    int a3 = x / 100 % 10; 
    int a4 = x / 1000 % 10; 
    int a5 = x / 10000; 

    if (a2 == a4 && a1 == a5)
    {
        Console.WriteLine("Yes, it is a palindrome");
    }
    else
    {
        Console.WriteLine("No, it is not a palindrome");
    }
}

Console.WriteLine("Enter five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Try again! You can write only five-digit number. ");
}
else
{
    CheckPalindrome(number);
}