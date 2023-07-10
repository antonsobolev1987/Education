// Программа принимает на вход три числа и проверяет может ли существовать
//треугольник с сторонами такой длины
//каждая сторона треугольника меньше суммы двух других сторон
//a<b+c
//b<a+c
//c<a+b

void Triangle(int firstSide, int secondSite, int thirdSide)
{
    int[] sides = { firstSide, secondSite, thirdSide };
    if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[0] + sides[1])
    {
        Console.WriteLine("Треугольник существует");

    }
    else Console.WriteLine("Треугольник не существует");
}

Triangle(3, 40, 500);