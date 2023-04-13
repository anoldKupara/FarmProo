using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.Contracts.Infrastructure
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<IEnumerable<Animal>> GetAnimalsByBreed(int breedId);
        Task<IEnumerable<Animal>> GetAnimalsByOwner(int ownerId);
    }
    {
    }
}
