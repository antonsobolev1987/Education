/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Random rnd = new Random();

int count1 = rnd.Next(-100, 100), count2 = rnd.Next(-100, 100), count3 = rnd.Next(-100, 100);
Console.WriteLine($"Сгенерированы числа {count1}, {count2}, {count3}");

if (count1 >= count2 && count1 >= count3)
{
    Console.WriteLine($"Максимальное число {count1}");
}
else if (count2 >= count1 && count2 >= count3)
{
    Console.WriteLine($"Максимальное число {count2}");
}
else
{
    Console.WriteLine($"Максимальное число {count3}");
}
