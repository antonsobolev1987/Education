/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

void ShowNumbers(int n)
{
    if (n > 1)
    {
        ShowNumbers(n - 1);
        Console.Write(n + " ");
    }
}

ShowNumbers(5);