// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int AmountNumbers(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10; 
        index++; 
    }
    return index;
}

int Sum(int num, int size)
{
    int sum = 0;

    for (int i = 1; i <= size; i++)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

int size = AmountNumbers(number);
int sum = Sum(number, size);
Console.WriteLine($"Сумму цифр в числе = {sum}");