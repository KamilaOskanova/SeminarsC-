// Написать программу, принимающую на вход координаты двух точек и 
// определяющую расстояние между ними

// Math.Sqrt - команда нахождения квадратного корня
// Math.Pow ( число, степень ) - команда возведения в степень

double GetDistance (double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
}

double xA, yA, xB, yB;
// double distance;

Console.WriteLine("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, xB, yB));