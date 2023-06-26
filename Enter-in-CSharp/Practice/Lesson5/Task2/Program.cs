//программа замены элемнтов массива. + на - и наоборот

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

int[] invertArray(int[] invArray)
{
    for (int i = 0; i < invArray.Length; i++)
    {
        invArray[i] = invArray[i] * (-1);

    }
    return invArray;
}

int [] arr = randomArray();
printArray(arr);
invertArray(arr);
printArray(arr);