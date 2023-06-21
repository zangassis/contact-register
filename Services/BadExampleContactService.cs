using ContactRegister.Repository;
using ContactRegister.Models;

namespace ContactRegister.Services;

public class ContactService {

     private readonly IContactRepository _repository;

    public ContactService()
    {
        _repository = new ContactRepository(); // Manual dependency creation
    }

   public List<Contact> FindAllContacts() =>
       _repository.FindContacts();
}
