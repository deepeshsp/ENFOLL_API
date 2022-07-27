namespace ENFOLL.Models
{
    public class NGO
    {
        public int NgoId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string FocusArea { get; set; }

        public int ContactId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public ContactDetails ContactDetails { get; set; }
    }

}
