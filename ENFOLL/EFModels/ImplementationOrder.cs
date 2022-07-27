namespace ENFOLL.Models
{
    public class ImplementationOrder
    {
        public int OrderId { get; set; }

        public int ProjectId { get; set; }

        public decimal? InstallationCost { get; set; }

        public decimal? InspectionFees { get; set; }

        public decimal? ConnectionCharges { get; set; }

        public decimal? MiscCharges { get; set; }

        public int? Status { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
