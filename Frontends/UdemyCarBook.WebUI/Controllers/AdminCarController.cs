using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult>  Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7216/api/Cars/GetCarWithBrand");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
    }
}
