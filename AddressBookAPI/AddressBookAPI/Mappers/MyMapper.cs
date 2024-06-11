using AddressBookAPI.DTOs;
using AddressBookAPI.Models;

namespace AddressBookAPI.Mappers
{
    public class MyMapper
    {
        public DTOs.ClientInfo ToContactDTO(Contact contact)
        {
            var contactDTO = new DTOs.ClientInfo();
            contactDTO.Id = contact.Id;
            contactDTO.FirstName = contact.FirstName;
            contactDTO.LastName = contact.LastName;
            contactDTO.PhoneNumber = contact.Phone;
            contactDTO.Address = contact.Address;

            return contactDTO;
        }

        public List<DTOs.ClientInfo> ToContactDTOList(List<Contact> contacts)
        {

            List<DTOs.ClientInfo> contactsDTO = new List<DTOs.ClientInfo>();

            contacts.ForEach(contact =>
            {
                var contactDTO = new DTOs.ClientInfo();
                contactDTO.Id = contact.Id;
                contactDTO.FirstName = contact.FirstName;
                contactDTO.LastName = contact.LastName;
                contactDTO.PhoneNumber = contact.Phone;
                contactDTO.Address = contact.Address;

                contactsDTO.Add(contactDTO);
            });

            return contactsDTO;
        }
    }
}
