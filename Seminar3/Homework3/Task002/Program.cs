// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
    return distance;
}

double xA, yA, zA, xB, yB, zB;

Console.WriteLine("Enter X for Point A: ");
xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Y of Point A: ");
yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Z of Point A: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter X of Point B: ");
xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Y of Point B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Z of Point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance3D(xA, yA, zA, xB, yB, zB));