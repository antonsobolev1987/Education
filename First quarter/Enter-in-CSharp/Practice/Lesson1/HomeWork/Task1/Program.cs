/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Random rnd = new Random();

int count1 = rnd.Next(-100, 100), count2 = rnd.Next(-100,100);
Console.WriteLine("Первое число " + count1);
Console.WriteLine("Второе число " + count2);

if (count1 == count2)
{
    Console.WriteLine("Числа равны друг другу");
}
else if (count1 > count2)
{
    Console.WriteLine($"Первое число ({count1}) больше второго числа ({count2})");
}
else
{
    Console.WriteLine($"Второе число ({count2}) больше первого числа ({count1})");
}



