using Mock_2.Model.DTO;
using Mock_2.Model.Entity;
using System.ComponentModel;

namespace Mock_2.Service.IService
{
    public interface ICampusService
    {
        Task<List<CampusDTO>> GetCampusNameById(int id);
        Task<List<CampusDTO>> GetCampustByName(string name);
        Task<List<CampusDTO>> GetAllCampus();
       
        Task<CampusDTO> GetAddressCampusByName(string name);
    }
}
