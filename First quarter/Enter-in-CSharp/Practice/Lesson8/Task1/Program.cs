//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

int[,] Created2DArray(int rows, int cols, int minV, int maxV)
{
    int[,] createdArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray(int[,] printedarray)
{
    for (int i = 0; i < printedarray.GetLength(0); i++)
    {
        for (int j = 0; j < printedarray.GetLength(1); j++)
        {
            Console.Write(printedarray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRows(int[,] arrayToChange, int row1, int row2)
{
    if (row1 >= 0 &&
        row1 < arrayToChange.GetLength(0) &&
        row1 != row2 &&
        row2 >= 0 &&
        row2 < arrayToChange.GetLength(0))
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
    }
    else Console.WriteLine("Error!");
    return arrayToChange;
}

Console.Write("Input count of rows: ");
int userrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of cols: ");
int usercols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of min: ");
int usermin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of max: ");
int usermax = Convert.ToInt32(Console.ReadLine());

int[,] newArr = Created2DArray(userrows, usercols, usermin, usermax);
ShowArray(newArr);

Console.Write($"Enter number of the first row from 0 to {userrows - 1}: ");
int user_first_row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter number of the second row from 0 to {userrows - 1}: ");
int user_second_row = Convert.ToInt32(Console.ReadLine());

ShowArray(ChangeRows(newArr, user_first_row, user_second_row));