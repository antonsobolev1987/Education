//программа принимает на вход число N и выдает ряд квадратов чисел от 1 до N
//5 -> 1 4 9 16 25
//2 -> 1 4
void raschetPOW(int userNumber)
{
    int count = 1;
    Console.Write("Ряд квадратов представлен как:");
    while (count <= userNumber)
    {
        double result = Math.Pow(count, 2);
        count++;
        Console.Write($" {result}");
}
    }
    
Console.WriteLine("Введите число: ");
int userNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

while (userNumber == 0)
{
    Console.WriteLine("Невозможно вычислить квадратный корень из нуля");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
raschetPOW(userNumber);









