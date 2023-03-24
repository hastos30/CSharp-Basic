namespace Lesson_13
{
    enum Options
    {
        ShowContacts = 1,
        AddContact,
        RemoveContactById,
        Exit
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var contactStore = new ContactStore(new PersistentContactProvider());
            bool exit = false;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine($"{(int)Options.ShowContacts}. Show contacts");
                Console.WriteLine($"{(int)Options.AddContact}. Add contact");
                Console.WriteLine($"{(int)Options.RemoveContactById}. Remove contact by id");
                Console.WriteLine($"{(int)Options.Exit}. Exit");

                string option = Console.ReadLine();

                if (!Enum.TryParse(option, out Options selectedOption))
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                switch (selectedOption)
                {
                    case Options.ShowContacts:
                        Console.WriteLine("Contacts:");
                        foreach (var contact in contactStore)
                        {
                            Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Phone number: {contact.PhoneNumber}");
                        }
                        break;
                    case Options.AddContact:
                        Console.Write("Enter contact name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter contact phone number: ");
                        string phoneNumber = Console.ReadLine();

                        try
                        {
                            contactStore.Create(new Contact { Name = name, PhoneNumber = phoneNumber });
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
                    case Options.RemoveContactById:
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
                    case Options.Exit:
                        exit = true;
                        break;
                }
                Console.WriteLine();
            } while (!exit);
        }
    }
}