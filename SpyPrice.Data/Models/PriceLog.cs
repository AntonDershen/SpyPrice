using System;

namespace SpyPrice.Data.Models
{
    public class PriceLog
    {
        public int Id { get; set; }

        public decimal MaxPrice { get; set; }

        public decimal MinPrice { get; set; }

        public DateTime LogDate { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
