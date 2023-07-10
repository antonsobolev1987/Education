// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 8; N = 4 -> "4, 6, 7, 8"

void ShowNumRange(int n, int m){
if (n != m) ShowNumRange(Math.Min(n,m), Math.Max(n,m)-1);
Console.Write($"{Math.Max(n,m)} ");
}

ShowNumRange(10,20);