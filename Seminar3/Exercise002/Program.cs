// Написать программу, которая принимает на вход номер четверти 
// и выводит на экран диапазон координат, доступных в этой четверти

void GetCoord(int numQuart)
{
    /*if(numQuart == 1) Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х > 0, Y > 0. ");
    if(numQuart == 2) Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х < 0, Y > 0. ");
    if(numQuart == 3) Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х < 0, Y > 0. ");
    if(numQuart == 4) Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х > 0, Y < 0. ");*/

    switch (numQuart)
    {
        case 1: 
        {
            Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х > 0, Y > 0. ");
            break;
        }
        case 2: 
        {
            Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х < 0, Y > 0. ");
            break;
        }
        case 3: 
        {
            Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х < 0, Y > 0. ");
            break;
        }
        case 4: 
        {
            Console.WriteLine ("В данной четверти координаты могут быть в следующем диапозоне: Х > 0, Y < 0. ");
            break;
        }
        default: 
        {
            Console.WriteLine("Такой четверти не существует!");
            break;
        }
    }
}

int number;
Console.WriteLine("Введите номер четверти (целое число от 1 до 4): ");
number = Convert.ToInt32(Console.ReadLine());

GetCoord(number);