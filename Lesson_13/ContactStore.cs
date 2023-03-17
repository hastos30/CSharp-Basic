using Lesson_13.Interfaves;

namespace Lesson_13
{

    public class ContactStore : BaseContactStore
    {
        public ContactStore(IContactProvider contactProvider)
        : base(contactProvider)
        {
        }

        public override void Create(IContact contact)
        {
            _contacts.Add(contact);
        }

        public override IContact GetById(int id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return null;
        }

        public override IEnumerable<IContact> GetByName(string name)
        {
            List<IContact> result = new List<IContact>();
            foreach (var contact in _contacts)
            {
                if (contact.Name == name)
                {
                    result.Add(contact);
                }
            }
            return result;
        }

        public override IEnumerable<IContact> GetByPhoneNumber(string phoneNumber)
        {
            List<IContact> result = new List<IContact>();
            foreach (var contact in _contacts)
            {
                if (contact.PhoneNumber == phoneNumber)
                {
                    result.Add(contact);
                }
            }
            return result;
        }

        public override bool Remove(int id)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].Id == id)
                {
                    _contacts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public override void Update(IContact contact)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].Id == contact.Id)
                {
                    _contacts[i] = contact;
                    return;
                }
            }
        }
    }
}
