namespace ENFOLL.Models
{
    public class Transactions
    {
        public int TransactionsId { get; set; }

        public int FromUserId { get; set; }

        public int FromUserType { get; set; }

        public decimal? ToUserId { get; set; }

        public int ToUserType { get; set; }

        public decimal? Amount { get; set; }

        public int? Status { get; set; }

        public DateTime? Date { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
