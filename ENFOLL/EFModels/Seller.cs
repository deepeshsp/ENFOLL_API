namespace ENFOLL.Models
{
    public class Seller
    {
        public int SellerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ContactId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public ContactDetails ContactDetails { get; set; }
    }

}
