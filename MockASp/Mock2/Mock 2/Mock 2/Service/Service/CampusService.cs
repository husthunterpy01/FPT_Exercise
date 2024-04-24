using AutoMapper;
using Mock_2.Model.DTO;
using Mock_2.Model.Entity;
using Mock_2.Repository.UOW;
using Mock_2.Service.IService;
using System.Linq.Expressions;

namespace Mock_2.Service.Service
{
    public class CampusService : ICampusService
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly Mapper _mapper;
        public CampusService(IUnitOfWork unitofWork, Mapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        // Get the corresponding campus address by the campus name
        public Task<CampusDTO> GetAddressCampusByName(string name)
        {
            throw new NotImplementedException();
        }

        // Take all the campus information
        public async Task<List<CampusDTO>> GetAllCampus()
        {
            var campustList = await _unitofWork.GetGenericRepo<Campus>().GetAsync();
            return _mapper.Map<List<CampusDTO>>(campustList);
        }

    

        // Get the campus information through Id
        public async Task<List<CampusDTO>> GetCampusNameById(int id)
        {
            try
            {
                Expression<Func<Campus, bool>> filterExpression = camp => camp.CampusID == id;
                List<Campus> filterCampus = await _unitofWork.GetGenericRepo<Campus>().GetAsync(filterExpression);
                List<CampusDTO> filterCampusDTO = _mapper.Map<List<CampusDTO>>(filterCampus);
                if (filterCampusDTO == null || !filterCampus.Any())
                {
                    throw new Exception("No campuses found with following id");
                }
                return filterCampusDTO;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while getting the campuses list", ex);
            }
        }
        // Get the information through the campus name
        public async Task<List<CampusDTO>> GetCampustByName(string name)
        {
            try
            {
                Expression<Func<Campus, bool>> filterExpression = camp => camp.CampusName == name;
                List<Campus> filterCampus = await _unitofWork.GetGenericRepo<Campus>().GetAsync(filterExpression);
                List<CampusDTO> filterCampusDTO = _mapper.Map<List<CampusDTO>>(filterCampus);
                if (filterCampusDTO == null || !filterCampus.Any())
                {
                    throw new Exception("No campuses found with following id");
                }
                return filterCampusDTO;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while getting the campus list", ex);
            }
        }

        // Save Change
        public void SaveChange()
        {
            _unitofWork.Save();
        }

    }
}
