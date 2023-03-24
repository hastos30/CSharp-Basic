using Lesson_13.Interfaves;

namespace Lesson_13
{
    public class ContactStore : BaseContactStore, INotifiable
    {
        private readonly IContactSaveable _contactSaveable;
        
        public event SaveDelegate SaveEvent;

        public ContactStore(IContactProvider contactProvider)
        : base(contactProvider)
        {
            if (contactProvider is IContactSaveable contactSaveable)
            {
                _contactSaveable = contactSaveable;
                SaveEvent += _contactSaveable.Save;
            }
        }

        public override void Create(IContact contact)
        {
            if (_contacts.Any(c => c.Name == contact.Name))
            {
                throw new DeniedOperationException($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
            }
            int newId = 1;
            if (_contacts.Any())
            {
                newId = _contacts.Max(c => c.Id) + 1;
            }

            contact.Id = newId;
            _contacts.Add(contact);
            OnSaveEvent();
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
            var contactToRemove = _contacts.FirstOrDefault(c => c.Id == id);

            if (contactToRemove == null)
            {
                throw new DeniedOperationException($"Contact with {nameof(IContact.Id)} {id} is not exists");
            }
            _contacts.Remove(contactToRemove);
            OnSaveEvent();
            return true;
        }

        public override void Update(IContact contact)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].Id == contact.Id)
                {
                    _contacts[i] = contact;
                    OnSaveEvent();
                    return;
                }
            }
        }

        protected virtual void OnSaveEvent()
        {
            SaveEvent?.Invoke(_contacts);
        }
    }
}
