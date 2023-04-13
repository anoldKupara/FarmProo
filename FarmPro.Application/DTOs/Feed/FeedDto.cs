using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.DTOs.Feed
{
    public class FeedDto
    {
        public int FeedID { get; set; }
        public string FeedType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Quantity { get; set; }
        public string Comments { get; set; }
        public virtual ICollection<FeedConsumption> FeedConsumptions { get; set; }
    }
}
