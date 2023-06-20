//Программа принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//A(x1,y1); B(x2,y2)

//distanceAB = квадр. корень из (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)

Console.WriteLine("Введите координату X для точки А:");
int coordXPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки А:");
int coordYPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B:");
int coordXPointB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки B:");
int coordYPointB = Convert.ToInt32(Console.ReadLine());

double distAB(int coordXPointA, int coordYPointA, int coordXPointB, int coordYPointB)
{
    double result = Math.Sqrt(Math.Pow(coordXPointB - coordXPointA, 2) + Math.Pow(coordYPointB - coordYPointA, 2));
    Console.WriteLine($"2D-расстояние между точками = {result:f2}");
    return result;

}

void enterCoordPoint(int coordXPointA, int coordYPointA, int coordXPointB, int coordYPointB)
{
    while (coordXPointA == coordXPointB && coordXPointA == coordYPointA && coordXPointA == coordYPointB)
    {
        Console.WriteLine("Координаты точек не могут быть равными между собой! Введите заново");
        Console.WriteLine("Введите координату X для точки А:");
        coordXPointA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Y для точки А:");
        coordYPointA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату X для точки B:");
        coordXPointB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Y для точки B:");
        coordYPointB = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("ОК");
    distAB(coordXPointA, coordXPointB, coordYPointA, coordYPointB);
}

enterCoordPoint(coordXPointA, coordXPointB, coordYPointA, coordYPointB);


