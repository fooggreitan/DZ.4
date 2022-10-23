// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите cтепень: ");
int b = Convert.ToInt32(Console.ReadLine());

int RaisingDegree(int number, int degree)
{
    int res = 1;

    for (int i = 1; i <= degree; i++)
    {
        res = res * number;
    }

    return res;
}

int raisingDegree = RaisingDegree(a, b);
Console.WriteLine($"Степень числа = {raisingDegree}");