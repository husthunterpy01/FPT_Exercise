using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mock_2.Model;
using Mock_2.Model.DTO;
using Mock_2.Repository.UOW;
using Mock_2.Service.IService;
using Mock_2.Service.Service;
using System.Net;

namespace Mock_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : ControllerBase
    {
        public APIResponse _response;
        public IMapper _mapper;
        public ICampusService _campusService;
        public CampusController(IMapper mapper, ICampusService campusService)
        {
            _response = new();
            _mapper = mapper;
            _campusService = campusService;
        }


        // Return the list of all campuses
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetAllCampus()
        {
            try
            {
                _response.Result = await _campusService.GetAllCampus();
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        // Return the campus information by Id
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task 

    }
}
