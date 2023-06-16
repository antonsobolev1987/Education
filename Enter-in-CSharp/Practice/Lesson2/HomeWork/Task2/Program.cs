/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int inputNumber = Math.Abs(new Random().Next());
int intermNumber = 0;
Console.WriteLine($"Сгенерировано число {inputNumber}");
if (inputNumber >= 100)
{
    while(inputNumber > 999){
    inputNumber /= 10;
    }
    intermNumber = inputNumber % 10;
    Console.WriteLine($"3 цифра числа: {intermNumber}");
}

else
{
    Console.WriteLine($"В сгенерированном числе нет 3ей цифры!!");
}
