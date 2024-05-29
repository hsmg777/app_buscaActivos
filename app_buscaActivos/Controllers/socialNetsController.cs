using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using app_buscaActivos.Models;
using Newtonsoft.Json;

namespace app_buscaActivos.Controllers
{
    public class SocialNetsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SocialNetsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string query)
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://social-links-search.p.rapidapi.com/search-social-links?query={query}&social_networks=facebook%2Ctiktok%2Cinstagram%2Csnapchat%2Ctwitter%2Cyoutube%2Clinkedin%2Cgithub%2Cpinterest"),
                Headers =
                {
                    { "x-rapidapi-key", "7b94842645msh93c56907e88affdp1ce6fcjsn7543715a97fb" },
                    { "x-rapidapi-host", "social-links-search.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<socialNet.Rootobject>(body);
                return PartialView("_SearchResults", data);
            }
        }
    }
}
