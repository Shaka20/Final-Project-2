using AddressBookAPI.DTOs;
using AddressBookAPI.Models;

namespace AddressBookAPI.Services
{
    public interface IContactService
    {
        DTOs.ClientInfo CreateContact(DTOs.ClientInfo newContact);
        bool DeleteContact(int id);
        List<DTOs.ClientInfo> GetAllContacts();
        DTOs.ClientInfo GetContactById(int id);
        DTOs.ClientInfo UpdateContact(DTOs.ClientInfo updateContact);
    }
}
