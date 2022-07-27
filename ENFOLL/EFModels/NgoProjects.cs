namespace ENFOLL.Models
{
    public class NgoProjects
    {
        public int ProjectId { get; set; }

        public int NgoId { get; set; }

        public decimal? EnergyRequirement { get; set; }

        public decimal? Area { get; set; }

        public int? Status { get; set; }

        public int? LocationId { get; set; }

        public DateTime? CreatedDate { get; set; }

    }

}
