using AutoMapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Mock_2.Model.DTO;
using Mock_2.Repository.UOW;
using Mock_2.Service.IService;

namespace Mock_2.Service.Service
{
    public class AddressService : IAddressServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public AddressService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            unitOfWork = _unitOfWork;
            _mapper = mapper;   
            _HttpContextAccessor = httpContextAccessor;
        }
        public Task<List<AddressDTO>> GetAddressesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDTO>> GetGoogleMapLocationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
