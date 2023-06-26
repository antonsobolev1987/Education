//Найти произведение пар чисел в одномерном массиве
// Пара это первый и последний эл, и т.д.

int[] randomArray()
{
    int size = new Random().Next(4, 10);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-10, 11);
    }
    return randomArray;
}

void printArray(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {

        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int[] startArray = randomArray();
int size = startArray.Length;

int[] multiArray(int[] startArray)
{
    int[] temp;
    if (startArray.Length % 2 == 0)
    {
        temp = new int[size / 2];
    }
    else
    {
        temp = new int[size / 2 + 1];
        temp[size / 2] = startArray[size / 2];
    }
    for (int i = 0; i < size / 2; i++)
    {
        temp[i] = startArray[i] * startArray[startArray.Length - 1 - i];
    }
    return temp;
}

printArray(startArray);
int[] multi = multiArray(startArray);
printArray(multi);
