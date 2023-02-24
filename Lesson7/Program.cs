class Program
{

    static void Main(string[] args)
    {
        //PrintMethodSumToNumber();
        Add("Привет", "Мир!");
        Add(1, 2);
        Add(1.5, 2.4);
    }
    static void PrintMethodSumToNumber()
    {
        Console.WriteLine("Введите положительное число >= 1 : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма от 1 до {number} значения = {SumTo(number)}");
    }

    static int SumTo(int number)
    {

        if (number < 1) 
        {
            Console.WriteLine("Неприпустиме значення аргументу");
            return 0;
        }
        else if (number == 1) 
        {
            return 1;
        }
        else
        {
            return number + SumTo(number - 1);
        }
    }

    static void Add(int a, int b)
    {
        Console.WriteLine($"Сумма чисел {a} и {b} = {a + b}");
    }

    static void Add(double a, double b)
    {
        Console.WriteLine($"Сумма чисел {a} и {b} = {a + b}");
    }

    static void Add(string a, string b)
    {
        Console.WriteLine($"Сумма значений {a} и {b} = {a + b}");
    }
}