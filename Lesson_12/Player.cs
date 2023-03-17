namespace Lesson_12
{
    class Player : IPlayble, IRecordable
    {
        public void Pause()
        {
            Console.WriteLine("Запустить паузу...");
        }

        public void Play()
        {
            Console.WriteLine("Запустить проигрователь...");
        }

        public void Record()
        {
            Console.WriteLine("Запустить запись...");
        }

        public void Stop()
        {
            Console.WriteLine("Запустить остановку...");
        }
    }
}
