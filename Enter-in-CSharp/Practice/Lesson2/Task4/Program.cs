void UserData()
{
    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());

       if (num1 % 7 == 0 && num1 % 23 == 0)
    {
        Console.WriteLine("OK OK");
    }

    else
    {
        Console.WriteLine("NO");
    }
}
UserData();
