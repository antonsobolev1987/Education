// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
int count1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int count2 = Convert.ToInt32(Console.ReadLine());

int result = count2 % count1;
if (result == 0)
{
    Console.WriteLine("Число кратно!");
}
else
{
    Console.WriteLine(result);
}
