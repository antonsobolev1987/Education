/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату X для точки А:");
int coordXPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки А:");
int coordYPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки А:");
int coordZPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B:");
int coordXPointB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки B:");
int coordYPointB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки B:");
int coordZPointB = Convert.ToInt32(Console.ReadLine());

double distAB(int coordXPointA, int coordYPointA, int coordXPointB, int coordYPointB, int coordZPointA, int coordZPointB)
{
    double result = Math.Sqrt(Math.Pow(coordXPointB - coordXPointA, 2) + Math.Pow(coordYPointB - coordYPointA, 2) + Math.Pow(coordZPointB - coordZPointA, 2));
    Console.WriteLine($"3D-расстояние между точками = {result:f2}");
    return result;

}

void enterCoordPoint(int coordXPointA, int coordYPointA, int coordXPointB, int coordYPointB, int coordZPointA, int coordZPointB)
{
    while (coordXPointA == coordXPointB && coordXPointA == coordYPointA && coordXPointA == coordYPointB && coordXPointA == coordZPointA && coordXPointA == coordZPointB)
    {
        Console.WriteLine("Координаты точек не могут быть равными между собой! Введите заново");
        Console.WriteLine("Введите координату X для точки А:");
        coordXPointA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Y для точки А:");
        coordYPointA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Z для точки А:");
        coordZPointA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату X для точки B:");
        coordXPointB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Y для точки B:");
        coordYPointB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату Z для точки B:");
        coordZPointB = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine("ОК");
    distAB(coordXPointA, coordXPointB, coordYPointA, coordYPointB, coordZPointA, coordZPointB);
}

enterCoordPoint(coordXPointA, coordXPointB, coordYPointA, coordYPointB, coordZPointA, coordZPointB);
