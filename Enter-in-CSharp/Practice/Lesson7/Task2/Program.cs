/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3 [0,0] [0,1] [0,2] [0,3]
1 2 3 4 [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/
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

int[,] FillArray(){
    int userRows = 3;
    int userColls = 4;
    int[,] filled2darray = new int[userRows, userColls];
    for (int i = 0; i < userRows ; i++)
    {
        for (int j = 0; j < userColls ; j++)
        
            filled2darray[i, j] = i + j;
        
        return filled2darray;
    }
}

int[,] secondarray = FillArray();
Print2DArray(secondarray);