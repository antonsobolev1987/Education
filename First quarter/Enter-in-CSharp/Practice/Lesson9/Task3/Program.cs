/*
Программа принимает число и возвращает сумму его цифр
*/

int SumDigits(int n)
{
    if (n < 0) n *= -1;
    if (n == 0) return 0;
    return SumDigits(n / 10) + n % 10;
}

Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(n);
Console.Write(sum);