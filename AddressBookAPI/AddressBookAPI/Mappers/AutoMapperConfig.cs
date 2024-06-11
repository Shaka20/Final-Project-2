using AddressBookAPI.DTOs;
using AddressBookAPI.Models;
using AutoMapper;

namespace AddressBookAPI.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Contact, DTOs.ClientInfo>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone));
        }
    }
}
