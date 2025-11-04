using Microsoft.AspNetCore.Mvc;
using MushPredict.Service.Services.Abstractions;

namespace MushPredict.Web.Controllers
{
    public class MushCardController : Controller
    {
        private readonly ISpeciesService _speciesService;

        public MushCardController(ISpeciesService speciesService)
        {
            _speciesService = speciesService;
        }
        public async Task<IActionResult> Card()
        {
            var species = await _speciesService.GetAllSpeciesAsync();
            return View(species);
        }
    }
}
