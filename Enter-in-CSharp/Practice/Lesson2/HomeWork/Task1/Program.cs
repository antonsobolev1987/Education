/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

void userCount(int number1)
{
    number1 = System.Math.Abs(number1) % 100 / 10;
    Console.WriteLine($"Вторая цифра этого числа: {number1}");
}

Console.WriteLine("Введите трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 99 && number1 < 999 || number1 < -99 && number1 > -999)
{
    userCount(number1);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!!");
}
