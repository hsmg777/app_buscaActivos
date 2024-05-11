using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using app_buscaActivos.Models;
using Newtonsoft.Json;

namespace app_buscaActivos.Controllers
{
    public class SubdomainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly HttpClient _httpClient;

        public SubdomainController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        // GET: SubdomainController
       

        [HttpPost]
        public async Task<IActionResult> Search(string domain)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://subdomain-finder3.p.rapidapi.com/v1/subdomain-finder/?domain={domain}"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ca2de54915msh47c6f73f1c96837p100833jsnfdecc09caff8" },
                    { "X-RapidAPI-Host", "subdomain-finder3.p.rapidapi.com" },
                },
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var subdomains = JsonConvert.DeserializeObject<Subdominios>(responseBody);
                return PartialView("_ResultsPartial", subdomains);
            }
        }
    }
}
