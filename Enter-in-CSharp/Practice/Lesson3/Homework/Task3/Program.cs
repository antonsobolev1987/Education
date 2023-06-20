/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void raschetPOW(int userNumber)
{
    int count = 1;
    Console.Write("Ряд кубов представлен как:");
    while (count <= userNumber)
    {
        double result = Math.Pow(count, 3);
        count++;
        Console.Write($" {result}");
}
    }
    
Console.WriteLine("Введите число: ");
int userNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

while (userNumber == 0)
{
    Console.WriteLine("Невозможно возвести в куб 0. Введите корректное значение!");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
raschetPOW(userNumber);
