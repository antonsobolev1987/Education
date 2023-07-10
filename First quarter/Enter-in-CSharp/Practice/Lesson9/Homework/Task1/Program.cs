/*
Задайте значение N. Напишите программу, которая выведет все натуральные
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
int ShowRes(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ShowNumber(int n, int m)
{
    if (n == m) return n;
    else
    {
        Console.Write($"{ShowNumber(n, m + 1)}, ");
        return m;
    }
}

int n = ShowRes("Задайте число N: ");
if (n < 1)
{
    Console.WriteLine("Введите положительное число!");
    return;
}
Console.WriteLine("Натуральные числа в промежутке от N до 1");
Console.WriteLine(ShowNumber(n, 1));

