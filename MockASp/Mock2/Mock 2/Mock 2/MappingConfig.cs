using AutoMapper;
using Mock_2.Model.DTO;
using Mock_2.Model.Entity;

namespace Mock_2
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Address, AddressCreateDTO>().ReverseMap();
            CreateMap<Address, AddressUpdateDTO>().ReverseMap();
        }
    }
}
