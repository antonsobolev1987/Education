/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[,] Create2DArray()
{
    Console.WriteLine("Введите кол-во строк: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int userMinVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int userMaxVal = Convert.ToInt32(Console.ReadLine());

    double[,] created2DArray = new double[userRows, userColls];
    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArray[i, j] = new Random().Next(userMinVal, userMaxVal + 1);
        }
    }
    return created2DArray;
}

void Print2DArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + "  |  ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();

}

double[,] new2DArray = Create2DArray();
Print2DArray(new2DArray);

void averageArray(double[,] TwoDArray)
{
    double average = 0;
    Console.WriteLine($"Среднее для столбца:");
    for (int j = 0; j < new2DArray.GetLength(1); j++)

    {
        for (int i = 0; i < new2DArray.GetLength(0); i++)
        {
            average = (new2DArray[i, j] + average);
        }
        average = average / new2DArray.GetLength(0);
        Console.Write($" | {average}");
        average = 0;
    }
}

averageArray(new2DArray);

