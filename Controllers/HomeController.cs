using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Minhalabcompras.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Minhalabcompras.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MeuLayout()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Tempo()
        {
            //criar e configurar o cliente HTTP
            string baseAddress = "http://api.weatherstack.com/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
            string path = "current?access_key=08d9721c9f4a140a938f7325c3402e41&query=Almada";
            HttpResponseMessage response = client.GetAsync(path).Result;
            string myJsonResponse = await response.Content.ReadAsStringAsync();
            WeatherApiResponse apiResponse = JsonConvert.DeserializeObject<WeatherApiResponse>(myJsonResponse);
            return View(apiResponse);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
