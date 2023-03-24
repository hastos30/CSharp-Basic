
namespace Lesson_13.Interfaves
{
    public interface IContactSaveable
    {
        bool Save(IEnumerable<IContact> items);
    }
}
