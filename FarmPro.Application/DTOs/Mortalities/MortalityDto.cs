using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.DTOs.Mortalities
{
    public class MortalityDto
    {
        public int MortalityID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
