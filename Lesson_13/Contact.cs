using Lesson_13.Interfaves;

namespace Lesson_13
{
    internal class Contact : IContact
    {
        string IContact.Name { get; set; }
        string IContact.PhoneNumber { get; set; }
        int IIdentity.Id { get; set; }
    }
}
