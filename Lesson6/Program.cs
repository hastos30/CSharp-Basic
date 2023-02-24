class Program
{
    static void Main(string[] args)
    {
     /*
     * setNum1 и setNum2 можно было бы сделать одним методом, поскольку выполняется тоже самое
     * но решил сделать отдельно, что бы продемонстрировать манипуляцию методами. В целом этоу
     * программу можно было бы еще больше оптимизировать, но выходя из условий задания - все сделал :) 
     */
        Calculator();
    }

    static void Calculator()
    {
        bool startStop = false;
        do
        {
            int num1 = SetNum1();
            int num2 = SetNum2();
            int result = SetOperation(num1, num2);
            Console.WriteLine($"Результат исчисления: {result}");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            Console.WriteLine("Еще? 1 - да, 2 - нет");
            char yesOrNo  = char.Parse(Console.ReadLine());
                if(yesOrNo == '1') startStop= true;
                else startStop = false;
        }while(startStop);
    }
    
    static int SetNum1()
    {
        Console.WriteLine("Введите первое целое число: ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    static int SetNum2()
    {
        Console.WriteLine("Введите второе целое число: ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    static int SetOperation(int num1, int num2)
    {
        Console.WriteLine("Введите тип операции: ( + - / * ^ ) ");
        char oper = Convert.ToChar(Console.ReadLine());
        int result = 0;

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
                default:
                    Console.WriteLine("Недопустимый символ!");
                    break;
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