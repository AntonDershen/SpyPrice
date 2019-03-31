using System.Collections.Generic;

namespace SpyPrice.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int ItemCategoryId { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }

        public List<PriceLog> PriceHistory { get; set; }

        public List<RateLog> RateHistory { get; set; }

        public Item(string name, string code, int itemCategoryId)
        {
            Name = name;
            Code = code;
            ItemCategoryId = itemCategoryId;
        }
    }
}
