using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Domain.Entities
{
    public class Egg
    {
        public int EggID { get; set; }
        public int AnimalID { get; set; }
        public DateTime LayDate { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
