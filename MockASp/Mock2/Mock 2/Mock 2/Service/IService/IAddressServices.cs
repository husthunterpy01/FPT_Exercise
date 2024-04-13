using Mock_2.Model.DTO;

namespace Mock_2.Service.IService
{
    public interface IAddressServices
    {
        Task<List<AddressDTO>> GetAddressesById(int id);
        Task<List<AddressDTO>> GetGoogleMapLocationById(int id);
    }
}
