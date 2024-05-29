using app_buscaActivos.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace app_buscaActivos.Controllers
{
    public class GoogleController : Controller
    {
        private readonly HttpClient _httpClient;

        public GoogleController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("X-API-KEY", "877a1ab9e5abc9c1f3f741281a4cf8a62bc4a68d");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string query)
        {
            var body = new { q = query };
            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://google.serper.dev/search", content);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Error al obtener los datos de la API");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var searchResults = JsonConvert.DeserializeObject<googleSearch.Rootobject>(responseContent);

            return PartialView("_SearchResultsPartial", searchResults.organic);
        }
    }
}
