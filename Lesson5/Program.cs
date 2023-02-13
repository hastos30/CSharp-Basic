class Program
{
    static void Main(string[] args)
    {
        bool startStop = false;
        do
        {
            Console.WriteLine("Введите нечетное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int center = number / 2;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i - number + 1 && j <= center - i + number - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Хотите еще? 1 - да, 2 - нет");
            int result = Convert.ToInt32(Console.ReadLine());
            if(result == 1)
               startStop = true;
            else if(result == 2)
                startStop = false;
        }
        while(startStop);
        
    }
}