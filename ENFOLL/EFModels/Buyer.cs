using System.ComponentModel.DataAnnotations;

namespace ENFOLL.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ContactId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public ContactDetails ContactDetails { get; set; }

    }
}