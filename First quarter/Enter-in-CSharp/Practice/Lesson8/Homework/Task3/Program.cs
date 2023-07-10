/*
Задайте две матрицы. Напишите программу, которая будет
 находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
int[,] CreatedArray(int sizeArroy)
{
    int[,] createdArray = new int[sizeArroy, sizeArroy];
    for (int i = 0; i < sizeArroy; i++)
        for (int j = 0; j < sizeArroy; j++)
            createdArray[i, j] = new Random().Next(1, 9);
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

Console.Write("Введите размерность создаваемых массивов: ");
int sizeArroy = Convert.ToInt32(Console.ReadLine());

int[,] firstArr = CreatedArray(sizeArroy);
Console.WriteLine("Сгенерирован 1-ый массив: ");
ShowArray(firstArr);

int[,] secondArr = CreatedArray(sizeArroy);
Console.WriteLine("Сгенерирован 2-ый массив: ");
ShowArray(secondArr);

int[,] resultArr = new int[sizeArroy, sizeArroy];
Console.WriteLine("---------------------------------------------");

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

Console.WriteLine("Произведение двух массивов представлено массивом: ");
MultiplyArray(firstArr, secondArr, resultArr);
ShowArray(resultArr);
