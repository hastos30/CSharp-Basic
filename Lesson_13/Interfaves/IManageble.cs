namespace Lesson_13.Interfaves
{
    public interface IManageable
    {
        void Create(IContact contact);

        bool Remove(int id);

        IContact GetById(int id);

        IEnumerable<IContact> GetByName(string name);

        IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);

        void Update(IContact contact);
    }
}