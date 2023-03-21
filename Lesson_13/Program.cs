namespace Lesson_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contactStore = new ContactStore(new InMemoryContactProvider());
            bool exit = false;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Show contacts");
                Console.WriteLine("2. Add contact");
                Console.WriteLine("3. Remove contact by id");
                Console.WriteLine("4. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Contacts:");
                        foreach (var contact in contactStore)
                        {
                            Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Phone number: {contact.PhoneNumber}");
                        }
                        break;
                    case "2":
                        Console.Write("Enter contact name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter contact phone number: ");
                        string phoneNumber = Console.ReadLine();
                        
                        try
                        {
                            contactStore.Create(new Contact { Name = name, PhoneNumber = phoneNumber});
                            Console.WriteLine("Contact added successfully");
                        }
                        catch (DeniedOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ooops... something went wrong");
                        }
                        break;
                    case "3":
                        Console.Write("Enter contact id: ");
                        int id = int.Parse(Console.ReadLine());
                        try
                        {
                            bool removed = contactStore.Remove(id);
                            if (removed)
                            {
                                Console.WriteLine("Contact removed successfully");
                            }
                            else
                            {
                                Console.WriteLine($"Contact with id {id} is not found");
                            }
                        }
                        catch (DeniedOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ooops... something went wrong");
                        }
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
            } while (!exit);
        }
    }
}