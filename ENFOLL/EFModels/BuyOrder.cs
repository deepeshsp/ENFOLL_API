namespace ENFOLL.Models
{
    public class BuyOrder
    {
        public int OrderId { get; set; }

        public int ProjectId { get; set; }

        public int BuyerId { get; set; }

        public decimal? EstimateCost { get; set; }

        public int? Status { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? LocationId { get; set; }

    }
}