//Не используя рекурсию вывести первые n чисел
//последовательности Фибоначчи

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

void Fibonacci(int n, int a, int b)
{
    int[] arrayFibonacci = new int[n];
    arrayFibonacci[0]  = a;
    arrayFibonacci[1] = b;
    for (int i = 2; i < n; i++)
    {
        arrayFibonacci[i] = arrayFibonacci[i - 1] + arrayFibonacci[i - 2];
    }
    printArray(arrayFibonacci);
}

Console.Write("Введите число элементов: ");
int userCount = Convert.ToInt32(Console.ReadLine());

if (userCount > 2)
{
    Console.WriteLine("Введите 1 значение: ");
    int userFirstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 значение: ");
    int userSecondNum = Convert.ToInt32(Console.ReadLine());
    Fibonacci(userCount, userFirstNum, userSecondNum);
}
else Console.WriteLine("Не верные значения");
