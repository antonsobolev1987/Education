// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
void enterCount(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        Console.WriteLine("OK");
    }
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
enterCount(num1, num2);