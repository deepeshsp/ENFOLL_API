using ENFOLL.Context;
using ENFOLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ENFOLL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NgoController : ControllerBase
    { 
        private readonly ILogger<NgoController> _logger;
        private EnfollContext _context;

        public NgoController(ILogger<NgoController> logger, EnfollContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetAllNgo")]
        public IActionResult Get()
        {

            return Ok(_context.NGO);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var ngo = _context.NGO.Where(x => x.NgoId == id);
            if(ngo == null) return NotFound();

            return Ok(ngo);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, NGO postngo)
        {
            if (id != postngo.NgoId)
                return BadRequest("NGO ID mismatch");

            var ngo = _context.NGO.Where(x => x.NgoId == id).FirstOrDefault();
            if (ngo == null) return NotFound();

            if (ngo == null)
                return NotFound($"NGO with Id = {id} not found");

            ngo.Name = postngo.Name;
            ngo.ContactDetails.Address = postngo.ContactDetails.Address;
            ngo.ContactDetails.City = postngo.ContactDetails.City;
            ngo.ContactDetails.State = postngo.ContactDetails.State;
            ngo.ContactDetails.Email = postngo.ContactDetails.Email;
            ngo.ContactDetails.PhoneNo = postngo.ContactDetails.PhoneNo;

            _context.SaveChanges();
            return Ok(ngo);

        }

        [HttpPost()]
        public IActionResult Post(Models.NGO ngo)
        {
            if(ngo != null)
            {
                _context.NGO.Add(ngo);
                _context.SaveChanges();
                return Ok(ngo);
            }
            else
            {
                return BadRequest();
            } 
        }
    }
}