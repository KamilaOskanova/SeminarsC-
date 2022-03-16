//Условие: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N. 

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n * (-1);

while(neg_n <= n)
{
    Console.WriteLine(neg_n);
    // Console.Write(neg_n + " ");
    neg_n++; 
    // neg_n++ - увеличается на единицу
    // neg_n+=3 - переход через 3 единицы
}