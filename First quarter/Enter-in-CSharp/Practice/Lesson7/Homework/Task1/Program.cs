/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Create2DArray()
{
    int userRows = 3;
    int userColls = 4;


    double[,] created2DArray = new double[userRows, userColls];
    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArray[i, j] = Math.Round((new Random().Next(-100, 100) + new Random().NextDouble()), 1);
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
