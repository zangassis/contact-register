using ContactRegister.Models;

namespace ContactRegister.Repository;

public class ContactRepository : IContactRepository
{
    public List<Contact>  FindContacts(){
        var contacts = new List<Contact>(){
            new Contact(Guid.NewGuid(), "John Smith", "jsmith@examplemail.com", "987654321")
        };
        return contacts;
    }
}