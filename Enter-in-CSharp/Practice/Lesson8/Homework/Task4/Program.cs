/*
.Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу, которая будет
  построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1
*/
Console.Write("Задайте длину массива: ");
int userx = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте ширину массива: ");
int usery = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте глубину массива: ");
int userz = Convert.ToInt32(Console.ReadLine());
int[,,] newArr = Created3DArray(userx,usery,userz);
ShowArray(newArr);

int [,,]Created3DArray(int x, int y, int z)
{
    int[,,] createdArray = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int randNumber = new Random().Next(10, 100);
                while (array3dcheck(createdArray, randNumber))
                {
                    randNumber = new Random().Next(10, 100);
                }
                createdArray[i, j, k] = randNumber;
            }
        }
    }
    return createdArray;
}

bool array3dcheck(int[,,] array3d, int randNumber)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                if (array3d[i, j, k] == randNumber)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void ShowArray(int[,,] printedarray)
{
    for (int i = 0; i < printedarray.GetLength(0); i++)
    {
        for (int j = 0; j < printedarray.GetLength(1); j++)
        {
            for (int k = 0; k < printedarray.GetLength(2); k++)
            {
                Console.Write(printedarray[i, j, k] + " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




