//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Input count of rows: ");
int userrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of cols: ");
int usercols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of min: ");
int usermin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of max: ");
int usermax = Convert.ToInt32(Console.ReadLine());
int[,] newArr = Created2DArray(userrows, usercols, usermin, usermax);

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


int[,] ExchRowsCols(int[,] arrToChange)
{
    int[,] tempArr = new int[arrToChange.GetLength(0), arrToChange.GetLength(1)];
    if (arrToChange.GetLength(0) == arrToChange.GetLength(1))
    {
        for (int i = 0; i < arrToChange.GetLength(0); i++)
        {
            for (int j = 0; j < arrToChange.GetLength(1); j++)
            {
                tempArr[j, i] = arrToChange[i, j];
            }
        }
        return tempArr;
    }
    else
    {
        Console.WriteLine("Error!");
        return arrToChange;
    }
}

ShowArray(Created2DArray(userrows, usercols, usermin, usermax));
Console.WriteLine("");
ShowArray(ExchRowsCols(newArr));





