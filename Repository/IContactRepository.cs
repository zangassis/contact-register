
using ContactRegister.Models;

namespace ContactRegister.Repository;

public interface IContactRepository{
    public List<Contact> FindContacts();
}