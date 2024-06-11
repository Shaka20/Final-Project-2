using AddressBookAPI.DTOs;
using AddressBookAPI.Models;
using AddressBookAPI.NewFolder;

namespace AddressBookAPI.Services
{
    public class BetterContactService : IContactService
    {
        private readonly ApplicationDbContext _context;
     
        public BetterContactService(ApplicationDbContext context) {
            _context = context;
        }   
        public DTOs.ClientInfo CreateContact(DTOs.ClientInfo newContact)
        {
            DTOs.ClientInfo clientInfo = new DTOs.ClientInfo();

            clientInfo.Id = newContact.Id;
            clientInfo.FirstName = newContact.FirstName;
            clientInfo.MiddleName = newContact.MiddleName;
            clientInfo.LastName = newContact.LastName;
            clientInfo.PhoneNumber = newContact.PhoneNumber;
            clientInfo.Address = newContact.Address;

            _context.AddClientInfo(clientInfo);
            return null;
        }

        public bool DeleteContact(int id)
        {
           return _context.DeleteClientInfo(id);
        }

        public List<DTOs.ClientInfo> GetAllContacts()
        {
            return _context.ClientInfos.ToList();
        }

        public DTOs.ClientInfo GetContactById(int id)
        {
            return _context.GetClientInfoById(id);
        }

        public DTOs.ClientInfo UpdateContact(DTOs.ClientInfo updateContact)
        {
            _context.UpdateClientInfo(updateContact);
            return null;
        }
    }
}
