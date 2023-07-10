//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] createnewArray(int size, int minVal, int maxVal)
{
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arrayNew;
}

void printArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1)
        {
            Console.Write(" | ");
        }
    }
    Console.WriteLine();
}

int[] reverseArray(int[] arrayReverse)
{
    int sizeArray = arrayReverse.Length;
    for (int i = 0; i < sizeArray / 2; i++)
    {
        int temp = arrayReverse[i];
        arrayReverse[i] = arrayReverse[sizeArray - 1 - i];
        arrayReverse[sizeArray - 1 - i] = temp;
    }
    return arrayReverse;
}

int size_array = 6;
int minVal_array = -9;
int maxVal_array = 9;

int[] createArray = createnewArray(size_array, minVal_array, maxVal_array);
printArray(createArray);
int[] reverse_array = reverseArray(createArray);
printArray(reverse_array);