using Mock_2.Interface.IUOW;
using Mock_2.Model.DTO;
using Mock_2.Service.IService;

namespace Mock_2.Service.Service
{
    public class AddressService : IAddressServices
    {
        private IUnitOfWork _UnitOfWork;
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
