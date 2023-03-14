namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            
            player1.Play();
            player1.Pause();
            player1.Stop();
            Console.WriteLine();
            player1.Record();
            player1.Pause();
            player1.Stop();

        }
    }
}