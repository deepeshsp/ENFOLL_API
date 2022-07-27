namespace ENFOLL.Models
{
    public class MatchedOrder
    {
        public int OrderId { get; set; }

        public int SellOrderId { get; set; }

        public int BuyerOrderId { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitCount { get; set; }

        public decimal? EnergyCapacity { get; set; }

        public decimal? TransportationCost { get; set; }

        public decimal? MiscCharges { get; set; }

        public int? Status { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedDate { get; set; }

    }

}