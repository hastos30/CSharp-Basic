class Program
{
    static void Main(string[] args)
    {
        //оператор if-else
        //AuthenticationIfElse();


        //оператор switch
        //AuthenticationSwitch();
        
        //оператор тернарный
        AuthenticationTernary();
    }

    static void AuthenticationIfElse()
    {
        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();

        if(login == "USER")
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            if(password == "KILLME")
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

            if(password == "KILLME")
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
        else if(login == "")
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
                        AuthenticationIfElse();
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
                        AuthenticationIfElse();
                        break;
                }
                break;
            case "":
                Console.WriteLine("\nHello Anonimous");
                break;
                
            default:
                Console.WriteLine("Login is not correct.");
                Console.WriteLine();
                AuthenticationIfElse();
                break;
        }
    }
    static void AuthenticationTernary()
    {
        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();
        string message;
        
        if (login == "USER") { Console.WriteLine(LoginUser()); }
        else if (login == "ADMIN") { Console.WriteLine(LoginAdmin()); }
        else if (login == "") { Console.WriteLine(LoginAnonimus()); }
        else 
        {
            Console.WriteLine("Login is not correct.");
            Console.WriteLine();
            AuthenticationIfElse();
        }
     }
    static string LoginUser()
    {
        Console.WriteLine("Введите пароль: ");
        string password = Console.ReadLine();
        string message = (password == "KILLME")
            ? "Hello User"
            : "Password is not correct.";
        return message;
    }
    static string LoginAdmin()
    {
        Console.WriteLine("Введите пароль: ");
        string password = Console.ReadLine();
        string message = password == "KILLME"
            ? "Hello Administrator"
            : "Password is not correct.";
        return message;
    }
    static string LoginAnonimus() => "Hello Anonimous";
}