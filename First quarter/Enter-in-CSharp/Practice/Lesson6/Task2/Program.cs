//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
int countOfBinar(int user_num)
{
    int countOfDigit = 0;
    while (user_num != 0)
    {
        user_num = user_num / 2;
        countOfDigit++;
    }
    return countOfDigit;
}

int[] conversionToBinar(int numToConvert)
{
    int n = countOfBinar(numToConvert);
    int[] binarNum = new int[n];
    for (int i = n - 1; i >= 0; i--)
    {
        binarNum[i] = numToConvert % 2;
        numToConvert /= 2;
    }

    return binarNum;
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

int userNumber = 45;
int countElem = countOfBinar(userNumber);
int [] binar = conversionToBinar(userNumber);
printArray(binar);