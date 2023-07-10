/*
Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ShowNumRange(int n, int m)
{
    if (n == m) return n;
    else return ShowNumRange(n + 1, m) + n;
}

ShowNumRange(4, 8);
Console.WriteLine(ShowNumRange(4, 8));