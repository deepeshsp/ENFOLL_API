namespace ENFOLL.Models
{
    public class SellOrder
    {
        public int OrderId { get; set; }

        public int SellerId { get; set; }

        public string PanelType { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitCount { get; set; }

        public string Efficiency { get; set; }

        public bool? IsDonation { get; set; }

        public int? LocationId { get; set; }

        public int? Status { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
