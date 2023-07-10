/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число от 100: ");
int symbols = Convert.ToInt32(Console.ReadLine());
while (symbols < 100)
{
    Console.WriteLine("Слишком короткое число для проверки на палиндромность! Введите число от 100:");
    symbols = Convert.ToInt32(Console.ReadLine());
}
checkPal();

void checkPal()
{
    int tempsymbols = symbols;
    string strtempsymbols = "";
    while (tempsymbols > 0)
    {
        int ost = tempsymbols % 10;
        tempsymbols = tempsymbols /= 10;
        strtempsymbols = strtempsymbols + ost.ToString();
    }

    if (strtempsymbols == symbols.ToString())
    {
        Console.WriteLine("Ваше число палиндром");
    }
    else
        Console.WriteLine("Ваше число не палиндром");
}


