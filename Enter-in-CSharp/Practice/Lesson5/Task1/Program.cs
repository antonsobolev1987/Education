//Задайте массив из 12 элементов с -9 до 9
// Найти сумму - и + элементов массива

int[] generateArray(int lenghtArray, int minValue, int maxValue)
{
    int[] newArray = new int [lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void printArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i] + " ");
        //Console.WriteLine();
    }

}

void findSummaNegEl(int[] arrayNeg)
{
    int summaNegEl = 0;
    for (int i = 0; i < arrayNeg.Length; i++)
        if (arrayNeg[i] < 0)
            summaNegEl += arrayNeg[i];
    Console.WriteLine($"Summa negotiate elementov to array = {summaNegEl}");
}

void findSummaPosEl(int[] arrayPos)
{
    int summaPosEl = 0;
    for (int i = 0; i < arrayPos.Length; i++)
        if (arrayPos[i] > 0)
            summaPosEl += arrayPos[i];
    Console.WriteLine($"Summa negotiate elementov to array = {summaPosEl}");
}

int lenghtArray = 12;
int minValue = -9;
int maxValue = 9;

int [] createArray = generateArray(lenghtArray, minValue, maxValue);
printArray(createArray);
findSummaNegEl(createArray);
findSummaPosEl(createArray);
