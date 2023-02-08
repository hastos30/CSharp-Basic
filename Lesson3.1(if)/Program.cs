class Program
{
    static void Main(string[] args)
    {
        AuthenticationIfElse();
    }
    static void AuthenticationIfElse()
    {
        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();

        if (login == "USER")
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            if (password == "KILLME")
            {
                Console.WriteLine("\nHello User");
            }
            else
            {
                Console.WriteLine("Password is not correct.");
                Console.WriteLine();
                AuthenticationIfElse();
            }
        }
        else if (login == "ADMIN")
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            if (password == "KILLME")
            {
                Console.WriteLine("\nHello Administrator");
            }
            else
            {
                Console.WriteLine("Password is not correct.");
                Console.WriteLine();
                AuthenticationIfElse();
            }
        }
        else if (login == "")
        {
            Console.WriteLine("\nHello Anonimous");
        }
        else
        {
            Console.WriteLine("Login is not correct.");
            Console.WriteLine();
            AuthenticationIfElse();
        }
    }
}