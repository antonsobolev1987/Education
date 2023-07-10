/*
из положительного десятичного числа в двоичное
*/

string DecToBin(int n, ref string s)
{
    if (n > 0)
    {
        DecToBin(n / 2, ref s);
        s += (n % 2).ToString();
    }
    if (n == 0) return s;
    return s;
}

Console.WriteLine("Enter num:");
int n = Convert.ToInt32(Console.ReadLine());
string s = "";
string summ = DecToBin(n, ref s);
Console.Write(summ);