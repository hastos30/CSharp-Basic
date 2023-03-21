namespace Lesson_13
{
    class DeniedOperationException : Exception
    {
        public DeniedOperationException(string message) 
            : base(message)
        { 
        }
    }
}
