// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1, k1, b2, k2;

Console.Write("Введите число b1: ");
b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k1: ");
k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
k2 = Convert.ToDouble(Console.ReadLine());

double meaningX = default;
double meaningY = default;

void TochcaPer(double x, double y)
{
    x = (-b2 + b1)/(-k1 + k2);
    y = k2 * x + b2;

    Console.WriteLine($"({x};{y})");
}

TochcaPer(meaningX, meaningY);