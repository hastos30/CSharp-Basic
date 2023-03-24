using Newtonsoft.Json;
using Lesson_13.Interfaves;

namespace Lesson_13
{
    internal class PersistentContactProvider : IContactProvider, IContactSaveable
    {
        private readonly string _filePath = "contacts.txt";

        public IEnumerable<IContact> Get()
        {
            try
            {
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Contact>>(json);
            }
            catch (FileNotFoundException)
            {
                return new List<Contact>();
            }
            catch (Exception)
            {
                throw new Exception("Failed to read contacts from file");
            }
        }

        public bool Save(IEnumerable<IContact> items)
        {
            try
            {
                string json = JsonConvert.SerializeObject(items);
                File.WriteAllText(_filePath, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}