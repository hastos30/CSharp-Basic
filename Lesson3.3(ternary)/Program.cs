class Program
{
    static void Main(string[] args)
    {
        AuthenticationTernary();
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
            AuthenticationTernary();
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
