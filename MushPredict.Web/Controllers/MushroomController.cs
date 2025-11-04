using Microsoft.AspNetCore.Mvc;
using MushPredict.Service.Services.Abstractions;

namespace MushPredict.Web.Controllers
{
    public class MushroomController : Controller
    {
       
        private readonly ISpeciesService _speciesService;

        public MushroomController( ISpeciesService speciesService)
        {
            _speciesService = speciesService;
        }
        public async Task<IActionResult> Mush(Guid id)
        {
            var species = await _speciesService.GetByGuidSpecies(id);

            return View(species);
        }
    }
}
