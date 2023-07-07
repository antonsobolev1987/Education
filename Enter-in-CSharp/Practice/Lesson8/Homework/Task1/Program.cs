/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

int[,] SelectionSort(int[,] sortarray)
{
    for (int i = 0; i < sortarray.GetLength(0); i++)
    {
        int sizearr = 0;
        int tempcount = sortarray.GetLength(1);
        while (sizearr < tempcount)
        {
            for (int j = sizearr + 1; j < tempcount; j++)
            {
                if (sortarray[i, sizearr] < sortarray[i, j])
                {
                    int temp = sortarray[i, sizearr];
                    sortarray[i, sizearr] = sortarray[i, j];
                    sortarray[i, j] = temp;
                }
            }
            sizearr++;
        }
    }
    return sortarray;
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
Console.WriteLine();
ShowArray(SelectionSort(newArr));

