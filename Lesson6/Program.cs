class Program
{
    static void Main(string[] args)
    {
        Calculator();
    }

    static void Calculator()
    {
        bool startStop = false;
        do
        {
        int num1 = setNum1();
        int num2 = setNum2();
        int result = setOperation(num1, num2);
        Console.WriteLine($"Результат исчисления: {result}");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("Еще? 1 - да, 2 - нет");
            char yesOrNo  = char.Parse(Console.ReadLine());
            if(yesOrNo == '1') startStop= true;
            else startStop = false;
        }while(startStop);
    }

    static int setNum1()
    {
        Console.WriteLine("Введите первое целое число: ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    static int setNum2()
    {
        Console.WriteLine("Введите второе целое число: ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    static int setOperation(int num1, int num2)
    {
        Console.WriteLine("Введите тип операции: ( + - / * ^ ) ");
        char oper = Convert.ToChar(Console.ReadLine());
        int result = 0;

        if (oper == '+' || oper == '-' || oper == '/' || oper == '*' || oper == '^')
        {
            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя!");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        break;
                    }
                case '^':
                    result = Exponentiation(num1, num2);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Недопустимый символ!");
        }
        return result;
    }

    static int Exponentiation(int num1, int num2)
    {
        int result = 1;
        for (int i = 1; i <= num2; i++)
        {
            result *= num1;
        }
        return result;
    }
}