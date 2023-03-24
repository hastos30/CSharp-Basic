
namespace Lesson_13.Interfaves
{
    public delegate bool SaveDelegate(IEnumerable<IContact> contacts);

    public interface INotifiable
    {
        event SaveDelegate SaveEvent;
    }
}
