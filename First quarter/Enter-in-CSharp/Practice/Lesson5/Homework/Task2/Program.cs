/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] randomArray()
{
    int size = new Random().Next(1, 10);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
    return randomArray;
}

/*
Объясните пожалуйста почему если в Random не задавать ограничения, оставив Next(), то при генерации 9-ти значных положительных чисел
программа иногда выдает результатом отрицательное значение.
Пример
PS C:\Users\sobolevai\Desktop\Education\Enter-in-CSharp\Practice\Lesson5\Homework\Task2> dotnet run
810237632 1612163636 2051342957 1323785955 1799099730 349183714 429865848
Сумма значений элементов, стоящих на нечетных позициях = -1009833991
*/

void printArray(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {

        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}



int[] array = randomArray();
printArray(array);

int sumEl = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sumEl += array[i];
    }
}
Console.WriteLine($"Сумма значений элементов, стоящих на нечетных позициях = {sumEl}");
