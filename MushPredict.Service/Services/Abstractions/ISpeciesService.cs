using MushPredict.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Service.Services.Abstractions
{
    public interface ISpeciesService
    {
        Task<List<Species>> GetAllSpeciesAsync();
        Task<Species> GetSpeciesByNameAsync(string name);
        Task<Species> GetByGuidSpecies(Guid id);

    }
}
