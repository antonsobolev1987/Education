Console.WriteLine("Пожалуйста представьтесь");
string userName = Console.ReadLine();
if (userName is not null)
{
    if (userName.ToLower() == "маша")
    {
        Console.WriteLine("Ура! Это же " + userName + "!");
    }
    else
    {
        Console.WriteLine("Привет, " + userName + "!");
    }
}
else
{
    Console.WriteLine("Вы не ввели ни одного символа!!");
}
