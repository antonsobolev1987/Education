int[] arr = { 1, 5, 3, 7, 8, 2, 3, 9, 0 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPosition])
            {
                MinPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);