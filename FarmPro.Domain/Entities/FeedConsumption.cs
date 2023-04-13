using FarmPro.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Domain.Entities
{
    public class FeedConsumption 
    {
        public int FeedConsumptionID { get; set; }
        public int AnimalID { get; set; }
        public int FeedID { get; set; }
        public DateTime ConsumptionDate { get; set; }
        public decimal Quantity { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Feed Feed { get; set; }
    }
}
