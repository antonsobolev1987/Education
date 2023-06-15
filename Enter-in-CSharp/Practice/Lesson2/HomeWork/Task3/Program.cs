/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("Вы ввели " + dayWeek + " день недели. Это выходной!");
}
else
if (dayWeek == 1 || dayWeek == 2 || dayWeek == 3 || dayWeek == 4 || dayWeek == 5)
{
    Console.WriteLine("Вы ввели " + dayWeek + " день недели. Это будний день!");
}
else
if(dayWeek == 0 || dayWeek > 7){
    Console.WriteLine("Вы ввели число, несопоставимое ни с одним днем недели!");
}


