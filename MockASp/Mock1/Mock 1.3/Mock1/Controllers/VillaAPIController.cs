using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mock1.Data;
using Mock1.Model;
using Mock1.Model.DTO;
using Mock1.Repository;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mock1.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]

    public class VillaAPIController : ControllerBase
    {
        //private readonly ILogger<VillaAPIController> _logger;
        //public VillaAPIController(ILogger<VillaAPIController> logger)
        //{
        //    _logger = logger;
        //}

        //private readonly Logging.ILogging _logger;
        protected APIResponse _response;
        public readonly IVillaRepository _dbVilla;
        public readonly IMapper _mapper;
        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
        {
            _response = new();
            _mapper = mapper;
            _dbVilla = dbVilla;
        }

        //private readonly ApplicationDbContext _db;
        //public VillaAPIController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        //[HttpGet]
        //public IEnumerable<Villa> GetVillas()
        //{
        //    return new List<Villa>()
        //    {
        //        new Villa{Id = 1, Name = "Pool View" },
        //        new Villa{Id = 2, Name = "Beach View"}
        //    };

        //}
        //[HttpGet]
        //public IEnumerable<VillaDTO> GetVillas()
        //{
        //    return VillaStore.villaList;
        //}


        // Get Individual
        //[HttpGet("{id:int}")]
        //public VillaDTO GetVilla(int id)
        //{
        //    return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //}


        // Status Code
        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        //public ActionResult<VillaDTO> GetVilla(int id)
        //{
        //    if (id == 0)
        //    {
        //        _logger.Log("Get Villa Error with Id: " + id, "error");
        //        return BadRequest();
        //    }
        //    var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //    if (villa == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(villa);
        //}

        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villa = await _dbVilla.GetAsync(u => u.Id == id);
                if (villa == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<VillaDTO>(villa);
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

        //Response Type
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        //public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        //{
        //    //_logger.Log("Getting all the villas"," ");
        //    //return Ok(VillaStore.villaList);
        //    return  Ok(_db.Villas.ToList());
        //}
        //public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        //{
        //    return Ok(_db.Villas.ToListAsync());
        //}

        //public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        //{
        //    IEnumerable<Villa> villaList = await _db.Villas.ToListAsync();
        //    return Ok(_mapper.Map<List<VillaDTO>>(villaList));
        //}

        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
            _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        // Post type
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        //{
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return BadRequest(ModelState);
        //    //}
        //    if (VillaStore.villaList.FirstOrDefault(u => u.Name.ToLower() == villaDTO.Name) != null)
        //    {
        //        ModelState.AddModelError("Customer Error", "Villa already exists");
        //        return BadRequest(ModelState);
        //    }
        //    if (villaDTO == null)
        //    {
        //        return BadRequest(villaDTO);
        //    }
        //    if (villaDTO.Id > 0)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    villaDTO.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
        //    //VillaStore.villaList.Add(villaDTO);
        //    Villa villa = _mapper.Map<Villa>(villaDTO);
        //    //Villa villa = new()
        //    //{
        //    //    Id = villaDTO.Id,
        //    //    Name = villaDTO.Name,
        //    //    Details = villaDTO.Details,
        //    //    Rate = villaDTO.Rate,
        //    //    Occupancy = villaDTO.Occupancy,
        //    //    ImageUrl = villaDTO.ImageUrl,
        //    //    Amenity = villaDTO.Amenity
        //    //};
        //    _db.Villas.Add(villa);
        //    _db.SaveChanges();
        //    return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
        //}

        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            //if (VillaStore.villaList.FirstOrDefault(u => u.Name.ToLower() == createDTO.Name) != null)
            //{
            //    ModelState.AddModelError("Customer Error", "Villa already exists");
            //    return BadRequest(ModelState);
            //}
            if (await _dbVilla.GetAsync(u => u.Name.ToLower().Equals(createDTO.Name.ToLower())) != null)
            {
                ModelState.AddModelError("Customer Error", "Villa already exists");
                return BadRequest(ModelState);
            }
            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }
            //VillaStore.villaList.Add(villaDTO);
            Villa model = _mapper.Map<Villa>(createDTO);
            //Villa villa = new()
            //{
            //    Id = villaDTO.Id,
            //    Name = villaDTO.Name,
            //    Details = villaDTO.Details,
            //    Rate = villaDTO.Rate,
            //    Occupancy = villaDTO.Occupancy,
            //    ImageUrl = villaDTO.ImageUrl,
            //    Amenity = villaDTO.Amenity
            //};
            await _dbVilla.CreateAsync(model);
            return CreatedAtRoute("GetVilla", new { id = model.Id }, createDTO);
        }

        // Delete type
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            var villa = await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            //VillaStore.villaList.Remove(villa);
            _dbVilla.RemoveAsync(villa);
            return NoContent();
        }


        //public IActionResult DeleteVilla(int id)
        //{
        //    if (id == 0)
        //    {
        //        return BadRequest();
        //    }
        //    //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //    var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
        //    if (villa == null)
        //    {
        //        return NotFound();
        //    }
        //    //VillaStore.villaList.Remove(villa);
        //    _db.Villas.Remove(villa);
        //    _db.SaveChanges();
        //    return NoContent();
        //}

        // Update 
        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDTO)
        //{
        //    if (villaDTO == null || id != villaDTO.Id)
        //    {
        //        return BadRequest();
        //    }
        //    //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //    //villa.Name = villaDTO.Name;
        //    //villa.Sqft = villaDTO.Sqft;
        //    //villa.Occupancy = villaDTO.Occupancy;

        //    Villa villa = new()
        //    {
        //        Id = villaDTO.Id,
        //        Name = villaDTO.Name,
        //        Details = villaDTO.Details,
        //        Rate = villaDTO.Rate,
        //        Occupancy = villaDTO.Occupancy,
        //        ImageUrl = villaDTO.ImageUrl,
        //        Amenity = villaDTO.Amenity
        //    };
        //    _db.Villas.Update(villa);
        //    _db.SaveChanges();
        //    return NoContent();
        //}
        //public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        //{
        //    if (updateDTO == null || id != updateDTO.Id)
        //    {
        //        return BadRequest();
        //    }
        //    //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //    //villa.Name = villaDTO.Name;
        //    //villa.Sqft = villaDTO.Sqft;
        //    //villa.Occupancy = villaDTO.Occupancy;

        //    Villa villa = _mapper.Map<Villa>(updateDTO);
        //    _db.Villas.Update(villa);
        //    await _db.SaveChangesAsync();
        //    return NoContent();
        //}

        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {
                    return BadRequest();
                };

                Villa model = _mapper.Map<Villa>(updateDTO);
                await _dbVilla.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            } catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        // Patch
        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        //{
        //    if (patchDTO == null || id == 0)
        //    {
        //        return BadRequest();
        //    }
        //    var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        //    //VillaDTO villaDTO = new()
        //    //{
        //    //    Id = villa.Id,
        //    //    Name = villa.Name,
        //    //    Details = villa.Details,
        //    //    Rate = villa.Rate,
        //    //    Occupancy = villa.Occupancy,
        //    //    ImageUrl = villa.ImageUrl,
        //    //    Amenity = villa.Amenity
        //    //};
        //    VillaDTO villaDTO = _mapper.Map<VillaDTO>(villa);
        //    if (villa == null)
        //    {
        //        return BadRequest();
        //    }
        //    patchDTO.ApplyTo(villa, ModelState);
        //    //Villa model = new()
        //    //{
        //    //    Id = villaDTO.Id,
        //    //    Name = villaDTO.Name,
        //    //    Details = villaDTO.Details,
        //    //    Rate = villaDTO.Rate,
        //    //    Occupancy = villaDTO.Occupancy,
        //    //    ImageUrl = villaDTO.ImageUrl,
        //    //    Amenity = villaDTO.Amenity
        //    //};
        //    Villa model = _mapper.Map<Villa>(villaDTO);
        //    _db.Villas.Update(model);
        //    await _db.SaveChangesAsync();
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    return NoContent();
        //}

        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = _dbVilla.GetAsync(u => u.Id == id);
            VillaDTO villaDTO = _mapper.Map<VillaDTO>(villa);
            if (villa == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(villaDTO, ModelState);
            Villa model = _mapper.Map<Villa>(villaDTO);
            _dbVilla.UpdateAsync(model);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }


    }
}