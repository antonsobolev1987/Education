/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] Create2DArray()
{
    Console.WriteLine("Введите кол-во строк: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    

    int[,] created2DArray = new int[userRows, userColls];
    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArray[i, j] = new Random().Next(0,100);
        }
    }
    return created2DArray;
}

void Print2DArray(int[,] array2d)
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

int[,] new2DArray = Create2DArray();
Console.WriteLine("---------------");
Console.WriteLine("Задан массив:");
Print2DArray(new2DArray);

Console.WriteLine("Введите номер строки (i) в массиве:");
int positionRowsArray = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите номер столбца (j) в массиве:");
int positionColsArray = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (positionRowsArray > new2DArray.GetLength(0)+1 || positionColsArray > new2DArray.GetLength(1)+1)
 Console.WriteLine("Числа с такими координатами i, j  нет в массиве");

else{
 Console.WriteLine($"Значение элемента с координатами i ({positionRowsArray}), j ({positionColsArray}) = {new2DArray[positionRowsArray-1, positionColsArray-1]}");
}    
    