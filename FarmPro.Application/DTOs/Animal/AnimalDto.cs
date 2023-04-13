using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.DTOs.Animal
{
    public class AnimalDto
    {
        public int AnimalID { get; set; }
        public string AnimalType { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Comments { get; set; }
        public virtual ICollection<Egg> Eggs { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Mortality> Mortalities { get; set; }
        public virtual ICollection<FeedConsumption> FeedConsumptions { get; set; }
    }
}
