//Программу, которая по номеру плоскости определяет диапазон координат

void findCoord(int numberQuater)
{
    if (numberQuater == 1)
    {
        Console.WriteLine("В этой плоскости координаты принимают значение: x > 0, y > 0");
    }
    else if (numberQuater == 2)
    {
        Console.WriteLine("В этой плоскости координаты принимают значение: x < 0, y < 0");
    }
    else if (numberQuater == 3)
    {
        Console.WriteLine("В этой плоскости координаты принимают значение: x < 0, y > 0");
    }
    else if (numberQuater == 2)
    {
        Console.WriteLine("В этой плоскости координаты принимают значение: x > 0, y < 0");
    }
}

Console.WriteLine("Введите номер плоскости:");
int numberQuater = Convert.ToInt32(Console.ReadLine());
while (numberQuater <= 0 || numberQuater > 4)
{
    Console.WriteLine("Вы ввели некорректный номер четверти! Требуется значение от 1 до 4!");
    numberQuater = Convert.ToInt32(Console.ReadLine());
}

findCoord(numberQuater);


