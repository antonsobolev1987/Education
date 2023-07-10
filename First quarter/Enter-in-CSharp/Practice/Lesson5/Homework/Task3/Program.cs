/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(-100, 100);
}

Console.WriteLine("Задан массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1) Console.Write(" | ");
}
Console.WriteLine(" ");

double minValue = 0;
double maxValue = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];

    }
    else if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
}

double sumEl = maxValue - minValue;
Console.Write($"Разница между максимальным и минимальным элементом массива = {sumEl}");

