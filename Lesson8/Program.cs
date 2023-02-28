class Program
{
    static void Main(string[] args)
    {
        PrintTriangle();
    }

    static void PrintTriangle()
    {
        Console.Write("Введите количество строк, для обозначения велечины триугольника: ");
        
        int numberOfLine = int.Parse(Console.ReadLine());
        int[][] triangle = TriangleСreationLogic(numberOfLine);

        for (int i = 0; i < numberOfLine; i++)
        {
            for (int j = 0; j < 2 * numberOfLine - 1; j++)
            {
                if (triangle[i][j] == 1)
                {
                    Console.Write("*");
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static int[][] TriangleСreationLogic(int numberOfLine)
    {
        int[][] triangle = new int[numberOfLine][];

        for (int i = 0; i < numberOfLine; i++)
        {
            triangle[i] = new int[2 * numberOfLine - 1];

            for (int j = 0; j < 2 * numberOfLine - 1; j++)
            {
                if (j >= numberOfLine - 1 - i && j <= numberOfLine - 1 + i)
                {
                    triangle[i][j] = 1;
                }
                else
                {
                    triangle[i][j] = 0;
                }
            }
        }
        return triangle;
    }
}