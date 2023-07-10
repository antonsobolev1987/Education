/*
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1
*/

int[,] Create2DArray()
{
    Console.WriteLine("Введите кол-во строк: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение: ");
    int userMinVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int userMaxVal = Convert.ToInt32(Console.ReadLine());

    int[,] created2DArray = new int[userRows, userColls];
    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArray[i, j] = new Random().Next(userMinVal, userMaxVal + 1);
        }
    }
    return created2DArray;
}

void Print2DArray(int[,] array2d)
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

int[,] new2DArray = Create2DArray();
Print2DArray(new2DArray);