namespace ENFOLL.Models
{
    public class ContactDetails
    {
        public int ContactId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
