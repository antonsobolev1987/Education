//Задайте одномерный массив из 123 эл.
// Найти кол-во эл. массива, значения которых лежат в отрезке 10-99




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

void countOfIndex(int [] countArray){
    int count =0;
    for(int i =0; i< countArray.Length;i++){
        if (countArray[i]>=10&&countArray[i]<=99)
        count++;
    }
Console.WriteLine($"->{count}");
}

int [] randomArr = randomArray();
printArray(randomArr);
countOfIndex(randomArr);
