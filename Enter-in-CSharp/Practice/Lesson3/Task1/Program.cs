// на вход координаты точки (X и Y)
// X<>0 и Y<>0 и выдает номер четверти где эта точка

void findCoord(int pointX, int pointY)
{

    if (pointX > 0 && pointY > 0)
    {
        Console.WriteLine("Точка находится в первой плоскости");
    }

    if (pointX > 0 && pointY < 0)
    {
        Console.WriteLine("Точка находится в четвертой плоскости");
    }

    if (pointX < 0 && pointY < 0)
    {
        Console.WriteLine("Точка находится в третьей плоскости");
    }

    if (pointX < 0 && pointY < 0)
    {
        Console.WriteLine("Точка находится во второй плоскости");
    }
}

void checkCoord(int pointX, int pointY)
{
    if (pointX != 0 && pointY != 0)
    {
        Console.WriteLine("ОК");
    }
    else
    {
        Console.WriteLine("Координаты не могут иметь нулевых значений!");
    }
}

Console.WriteLine("Введите координату Х:");
int pointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int pointY = Convert.ToInt32(Console.ReadLine());

checkCoord(pointX, pointY);

findCoord(pointX, pointY);
