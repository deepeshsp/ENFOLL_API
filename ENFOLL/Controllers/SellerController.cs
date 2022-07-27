using ENFOLL.Context;
using ENFOLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ENFOLL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SellerController : ControllerBase
    { 
        private readonly ILogger<SellerController> _logger;
        private EnfollContext _context;

        public SellerController(ILogger<SellerController> logger, EnfollContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetAllSeller")]
        public IActionResult Get()
        {

            return Ok(_context.Seller);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var Seller = _context.Seller.Where(x => x.SellerId == id);
            if(Seller == null) return NotFound();

            return Ok(Seller);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Seller postSeller)
        {
            if (id != postSeller.SellerId)
                return BadRequest("Seller ID mismatch");

            var seller = _context.Seller.Where(x => x.SellerId == id).FirstOrDefault();
            if (seller == null) return NotFound();

            if (seller == null)
                return NotFound($"Seller with Id = {id} not found");


            seller.FirstName = postSeller.FirstName;
            seller.LastName = postSeller.LastName;
            seller.ContactDetails.Address = postSeller.ContactDetails.Address;
            seller.ContactDetails.City = postSeller.ContactDetails.City;
            seller.ContactDetails.State = postSeller.ContactDetails.State;
            seller.ContactDetails.Email = postSeller.ContactDetails.Email;
            seller.ContactDetails.PhoneNo = postSeller.ContactDetails.PhoneNo;

            _context.SaveChanges();
            return Ok(seller);
            
        }

        [HttpPost()]
        public IActionResult Post(Models.Seller Seller)
        {
            if(Seller != null)
            {
                _context.Seller.Add(Seller);
                _context.SaveChanges();
                return Ok(Seller);
            }
            else
            {
                return BadRequest();
            } 
        }
    }
}