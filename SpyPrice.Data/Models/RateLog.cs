using System;
using System.Collections.Generic;
using System.Text;

namespace SpyPrice.Data.Models
{
    public class RateLog
    {
        public int Id { get; set; }

        public int NumberOfVotes { get; set; }

        public int Rate { get; set; }

        public DateTime LogDate { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
