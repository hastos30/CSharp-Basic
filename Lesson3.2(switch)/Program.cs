class Program
{
    static void Main(string[] args)
    {
        AuthenticationSwitch();
    }

    static void AuthenticationSwitch()
    {
        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();
        string password;

        switch (login)
        {
            case "USER":
                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();

                switch (password)
                {
                    case "KILLME":
                        Console.WriteLine("\nHello User");
                        break;
                    default:
                        Console.WriteLine("Password is not correct.");
                        Console.WriteLine();
                        AuthenticationSwitch();
                        break;
                }
                break;

            case "ADMIN":
                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();

                switch (password)
                {
                    case "KILLME":
                        Console.WriteLine("\nHello Administrator");
                        break;
                    default:
                        Console.WriteLine("Password is not correct.");
                        Console.WriteLine();
                        AuthenticationSwitch();
                        break;
                }
                break;
            case "":
                Console.WriteLine("\nHello Anonimous");
                break;

            default:
                Console.WriteLine("Login is not correct.");
                Console.WriteLine();
                AuthenticationSwitch();
                break;
        }
    }
}