using Lesson_13.Interfaves;
using System.Collections;

namespace Lesson_13
{
    public abstract class BaseContactStore : IEnumerable<IContact>, IManageable
    {
        private readonly IContactProvider _contactProvider;

        protected List<IContact> _contacts;
        public abstract void Create(IContact contact);
        public abstract IContact GetById(int id);
        public abstract IEnumerable<IContact> GetByName(string name);
        public abstract IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);
        public abstract bool Remove(int id);
        public abstract void Update(IContact contact);

        protected BaseContactStore(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
            _contacts = _contactProvider.Get().ToList();
        }

        public IEnumerator<IContact> GetEnumerator()
        {
            return _contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
