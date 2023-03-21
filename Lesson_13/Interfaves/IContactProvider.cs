namespace Lesson_13.Interfaves
{
    public interface IContactProvider
    {
        IEnumerable<IContact> Get();
    }
}
