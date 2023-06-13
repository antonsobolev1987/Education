 Console.WriteLine("Пожалуйста представьтесь");
        string userName = Console.ReadLine();
        if (userName.ToLower() == "маша")
        {
            Console.WriteLine("Ура! Это же " + UserName + "!");
        }
        else
        {
            Console.WriteLine("Привет, " + UserName + "!");
        }
