using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.DTOs.Sales
{
    public class SaleDto
    {
        public int SaleID { get; set; }
        public int AnimalID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
