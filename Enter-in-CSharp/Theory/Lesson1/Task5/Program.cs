internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Пожалуйста представьтесь");
        string UserName = Console.ReadLine();
        if (UserName.ToLower() == "Маша")
        {
            Console.WriteLine("Ура! Это же " + UserName + "!");
        }
        else
        {
            Console.WriteLine("Привет, " + UserName + "!");
        }
    }
}