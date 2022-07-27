using ENFOLL.Context;
using ENFOLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ENFOLL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyerController : ControllerBase
    { 
        private readonly ILogger<BuyerController> _logger;
        private EnfollContext _context;

        public BuyerController(ILogger<BuyerController> logger, EnfollContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetAllBuyer")]
        public IActionResult Get()
        {

            return Ok(_context.Buyer);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var buyer = _context.Buyer.Where(x => x.BuyerId == id);
            if(buyer == null) return NotFound();

            return Ok(buyer);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Buyer postBuyer)
        {
            if (id != postBuyer.BuyerId)
                return BadRequest("Buyer ID mismatch");

            var buyer = _context.Buyer.Where(x => x.BuyerId == id).FirstOrDefault();
            if (buyer == null) return NotFound();

            if (buyer == null)
                return NotFound($"Buyer with Id = {id} not found");


            buyer.FirstName = postBuyer.FirstName;
            buyer.LastName = postBuyer.LastName;
            buyer.ContactDetails.Address = postBuyer.ContactDetails.Address;
            buyer.ContactDetails.City = postBuyer.ContactDetails.City;  
            buyer.ContactDetails.State = postBuyer.ContactDetails.State;
            buyer.ContactDetails.Email = postBuyer.ContactDetails.Email;    
            buyer.ContactDetails.PhoneNo = postBuyer.ContactDetails.PhoneNo;
               
            _context.SaveChanges();
            return Ok(buyer);
            
        }

        [HttpPost()]
        public IActionResult Post(Models.Buyer buyer)
        {
            if(buyer != null)
            {

                //_context.ContactDetails.Add(contactModel);
                _context.Buyer.Add(buyer);
                _context.SaveChanges();

                return Ok(buyer);
            }
            else
            {
                return BadRequest();
            } 
        }
    }
}