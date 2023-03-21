namespace Lesson_13.Interfaves
{
    public interface IContact : IIdentity
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
    }
}
