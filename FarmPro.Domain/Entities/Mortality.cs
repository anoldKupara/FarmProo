using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Domain.Entities
{
    public class Mortality
    {
        public int MortalityID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
