//Задача 1.
//Напишите программу, которая принимает на
// вход число (А) и выдаёт сумму чисел от 1 до А.

//int countA = Convert.toint32(math.abs(Console.readline());
//Console.writeline(countA);
void findsum1toA(int num_a)
{
    int sumOfElem = 0;
    for (int i = 0; i <= num_a; i++)
    {
        sumOfElem += i;
    }
    Console.WriteLine(sumOfElem + " ");
}

Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num > 0){

    findsum1toA(user_num);
}
else
{
    Console.WriteLine("Error!");
}