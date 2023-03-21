using Lesson_13.Interfaves;

namespace Lesson_13
{
    internal class InMemoryContactProvider : IContactProvider
    {
        public IEnumerable<IContact> Get()
        {
            return new List<IContact>();
        }
    }
}
