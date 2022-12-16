// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double GetX(double a, double b, double c, double d)
{
    double x = (c - a) / (b - d);
    return x;
}

double GetY(double a, double b, double x)
{
    double y = b * x + a;
    return y;
}

if(k1==k2 && b1==b2)
{
    Console.Write($"прямые совпадают");
}
else if(k1==k2)
{
 Console.Write($"прямые параллельны");
}
else
{
double X = GetX(b1, k1, b2, k2);
double Y = GetY(b1, k1, X);

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({X}; {Y})");
}