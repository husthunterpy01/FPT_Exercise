using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Mock_2.Model;
using Mock_2.Model.DTO;
using Mock_2.Model.Entity;
using Mock_2.Repository.UOW;
using System.Net;

namespace Mock_2.Controllers
{
    [Route("api/AddressApi")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AddressController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _response = new();
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        // Get All
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<APIResponse>> GetAllAddress()
        {
            try
            {
                IEnumerable<Address> addressList = await _unitOfWork.GetGenericRepo<Address>().GetAsync();
                _response.Result = _mapper.Map<List<AddressDTO>>(addressList);
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

        // Get By Id

        [HttpGet("{id:int}", Name = "GetAddressById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetAddressById(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var address = await _unitOfWork.GetGenericRepo<Address>().GetByIDAsync(u => u.AddressID == id);
                if (address == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<AddressDTO>(address);
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



        // Create Address
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<APIResponse>> CreateAddress([FromBody] AddressCreateDTO createDTO)
        {
            try
            {
                if (await _unitOfWork.GetGenericRepo<Address>().GetAsync(u => u.Adddresses.ToLower().Equals(createDTO.Addresses.ToLower())) != null)
                {
                    ModelState.AddModelError("Client Error", "Address already existed");
                    return BadRequest(ModelState);
                }
                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }
                Address address = _mapper.Map<Address>(createDTO);
                await _unitOfWork.GetGenericRepo<Address>().CreateAsync(address);
                return CreatedAtRoute(nameof(GetAddressById), new { id = address.AddressID }, createDTO);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }


        // Update Address
        [HttpPut("{id:int}", Name = "UpdateAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateAddress(int id, [FromBody] AddressUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.AddressID)
                {
                    return BadRequest();
                }
                Address address = _mapper.Map<Address>(updateDTO);
                await _unitOfWork.GetGenericRepo<Address>().UpdateAsync(address);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        // Update Address with Patch
        [HttpPatch("{id:int}", Name = "UpdatePartialAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<APIResponse>> UpdatePartialAddress(int id, JsonPatchDocument<AddressUpdateDTO> patchDTO)
        {
            try
            {
                if (patchDTO == null || id == 0)
                {
                    return BadRequest();
                }
                var address = _unitOfWork.GetGenericRepo<Address>().GetByIDAsync(u => u.AddressID == id);
                AddressUpdateDTO addressDTO = _mapper.Map<AddressUpdateDTO>(address);
                if (address == null)
                {
                    return BadRequest();
                }
                patchDTO.ApplyTo(addressDTO, ModelState);
                Address model = _mapper.Map<Address>(addressDTO);
                _unitOfWork.GetGenericRepo<Address>().UpdateAsync(model);

                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }



        // Delete Address
        [HttpDelete("{id:int}", Name = "DeleteAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteAddress(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var address = await _unitOfWork.GetGenericRepo<Address>().GetByIDAsync(u => u.AddressID == id);
                if (address == null)
                {
                    return NotFound();
                }

                await _unitOfWork.GetGenericRepo<Address>().DeleteAsync(address);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;

        }
    }
}
