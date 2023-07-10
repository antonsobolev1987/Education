/*
Задайте двумерный вещественный массив. Найдите элементы,
у которых оба индекса чётные,
и замените эти элементы на их квадраты.
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
            created2DArray[i, j] = Math.Round((new Random().Next(userMinVal, userMaxVal + 1) + new Random().NextDouble()), 2);
        }
    }
    return created2DArray;
}

double[,] ModifiedArray(double[,] arrayStart)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
        for (int j = 0; j < arrayStart.GetLength(1); j++)

            if (i % 2 == 0 && j % 2 == 0)
                arrayStart[i, j] *= Math.Round((arrayStart[i, j] * arrayStart[i, j]), 3);
    return arrayStart;
}

void Print2DArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] thirdtaskarray = Create2DArray();
Print2DArray(thirdtaskarray);
double[,] modifArray = ModifiedArray(thirdtaskarray);
Print2DArray(modifArray);