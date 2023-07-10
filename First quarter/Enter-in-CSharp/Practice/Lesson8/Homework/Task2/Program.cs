/*
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
Так и не победил момент, если в массиве много столбцов, и есть строки с одинаковыми
значениями суммы. Нумерация строк с выводом суммы сбивается
*/

Console.WriteLine("Будет сгенерирован случайный массив целых чисел в диапазоне от 0 до 9!");
Console.WriteLine("Укажите сколько в массиве строк: ");
int userrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите сколько в массиве столбцов: ");
int usercols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сгенерирован массив:");
int[,] newArr = Created2DArray(userrows, usercols);
ShowArray(newArr);

int[,] Created2DArray(int rows, int cols)
{
    int[,] createdArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            createdArray[i, j] = new Random().Next(0, 9);
    return createdArray;
}

void ShowArray(int[,] printedarray)
{
    for (int i = 0; i < printedarray.GetLength(0); i++)
    {
        for (int j = 0; j < printedarray.GetLength(1); j++)
        {
            Console.Write(printedarray[i, j] + "  |  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumEl(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Сумма элементов в строке {i+1} = {sum}");
    return sum;
}

int minSum = 1;
int sum = SumEl(newArr, 0);
for (int i = 1; i < newArr.GetLength(0); i++)
{
    if (sum > SumEl(newArr, i))
    {
        sum = SumEl(newArr, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");
