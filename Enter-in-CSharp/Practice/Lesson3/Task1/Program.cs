// на вход координаты точки (X и Y)
// X<>0 и Y<>0 и выдает номер четверти где эта точка

internal class Program
{
    private static void Main(string[] args)
    {
        int findCoord(int pointX, int pointY)
        {
            int numberQuater;

            if (pointX > 0 && pointY > 0)
            {
                numberQuater = 1;
            }

            else if (pointX > 0 && pointY < 0)
            {
                numberQuater = 4;
            }

            else if (pointX < 0 && pointY < 0)
            {
                numberQuater = 3;
            }

            else if (pointX < 0 && pointY < 0)
            {
                numberQuater = 2;
            }
            
            else
            {
                numberQuater = 0;
            }

            return numberQuater;
        }

        void checkCoord(int pointX, int pointY)
        {
            if (pointX != 0 && pointY != 0)
            {
                int numberQuater = findCoord(pointX, pointY);
                Console.WriteLine("Точка принадлежит " + numberQuater + " плоскости");
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
    }
}