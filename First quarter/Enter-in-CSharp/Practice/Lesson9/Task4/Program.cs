/*
Два числа, и возводит число а в целую степнь b
*/

double FindPow(int a, int b)
{
    if (b == 0) return 1.0;
    if (b > 0) return FindPow(a, b - 1) * a;
    return FindPow(a, b + 1) / a;
}

double res = FindPow(2, -3);
Console.WriteLine(res);