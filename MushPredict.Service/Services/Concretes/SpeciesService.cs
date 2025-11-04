using MushPredict.Data.UnitOfWorks;
using MushPredict.Entity.Entities;
using MushPredict.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Service.Services.Concretes
{
    public class SpeciesService : ISpeciesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpeciesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Species>> GetAllSpeciesAsync()
        {
            
            return await _unitOfWork.GetRepository<Species>().GetAllAsync(x=>!x.IsDeleted, x=>x.Image, x=>x.Kind);
            
            
        }

        public async Task<Species> GetByGuidSpecies(Guid id)
        {

            return await _unitOfWork.GetRepository<Species>().GetAsync(x=>x.Id==id,x=>x.Kind);


        }

        public async Task<Species> GetSpeciesByNameAsync(string name)
        {
            return await _unitOfWork.GetRepository<Species>().GetAsync(x => !x.IsDeleted && x.Name == name,x=>x.Kind);
        }
    }
}
