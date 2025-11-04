using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MushPredict.Service.Services.Abstractions;
using MushPredict.Entity.Dtos.Predict;

namespace MushPredict.Web.Controllers
{
    public class PredictController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ISpeciesService _speciesService;

        public PredictController(HttpClient httpClient, ISpeciesService speciesService)
        {
            _httpClient = httpClient;
            _speciesService = speciesService;
        }

        [HttpGet]
        public async Task<IActionResult> Upload()
        {
            
           

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                ViewBag.Error = "Lütfen bir görüntü dosyası seçin.";
                return View();
            }

            using var content = new MultipartFormDataContent();
            using var fileStream = imageFile.OpenReadStream();
            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType);
            content.Add(fileContent, "imagefile", imageFile.FileName);





            var response = await _httpClient.PostAsync("http://localhost:3000/predict", content);



            if (!response.IsSuccessStatusCode || response is null)
            {
                ViewBag.Error = "Flask API çağrısında bir hata oluştu.";
                return View();
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var predictionResult = JsonConvert.DeserializeObject<PredictionResult>(responseContent);

            ViewBag.Prediction = predictionResult.Prediction;
            ViewBag.Confidence = predictionResult.Confidence.Remove(5);

            var findSpecies = await _speciesService.GetSpeciesByNameAsync(predictionResult.Prediction);

            if(findSpecies is not null)
            {
                return View(findSpecies);
            }

            return View();
        }
    }
}
