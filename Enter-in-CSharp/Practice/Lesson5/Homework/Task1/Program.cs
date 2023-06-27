/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] randomArray()
{
    int size = new Random().Next(1, 10);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(99, 1000);
    }
    return randomArray;
}

void printArray(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {

        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}


int [] array =  randomArray();
printArray(array);

int kolEl = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        kolEl++;
    }
    }
Console.WriteLine($"Кол-во четных чисел в массиве = {kolEl}");



