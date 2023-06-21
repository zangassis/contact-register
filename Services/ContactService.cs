using ContactRegister.Repository;
using ContactRegister.Models;

namespace ContactRegister.Services;

public class ContactService {
    private readonly IContactRepository _repository;

    public ContactService(IContactRepository repository)
    {
        _repository = repository;
    }

    public List<Contact> FindAllContacts() =>
        _repository.FindContacts();
}