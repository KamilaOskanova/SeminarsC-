//Написать программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetQuart(double pointX, double pointY)
{
    if(pointX > 0 && pointY > 0)
    {
        return 1;
    }
    // if(pointX > 0 && pointY > 0) return 1;  если одна операция, то можно записать в таком формате
    if(pointX < 0 && pointY > 0)
    {
        return 2;
    }

    if(pointX < 0 && pointY < 0)
    {
        return 3;
    }

    if(pointX > 0 && pointY < 0)
    {
        return 4;
    }
     
   return 0;
}

double x, y;
int quartNum;
Console.WriteLine("Input x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);

if(quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти.");