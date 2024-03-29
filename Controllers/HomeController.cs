﻿using Microsoft.AspNetCore.Mvc;
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
using System.Runtime.Serialization;
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI;
using VisioForge.MediaFramework.DSP;


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

        [HttpGet]
        public async Task<IActionResult> Tempo()
        {
          //criar e configurar o cliente HTTP
             string baseAddress = "http://api.weatherstack.com/";

            HttpClient cliente = new HttpClient();
             cliente.BaseAddress = new Uri(baseAddress);
            cliente.DefaultRequestHeaders.Accept.Clear();
             cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
              string path = "current?access_key=08d9721c9f4a140a938f7325c3402e41&query=Almada";
              HttpResponseMessage response = cliente.GetAsync(path).Result;
              string myJsonResponse = await response.Content.ReadAsStringAsync();
             WeatherApiResponse apiResponse = JsonConvert.DeserializeObject<WeatherApiResponse>(myJsonResponse);
               return View(apiResponse);
       
        }

        [HttpPost]
        public async Task<IActionResult> Tempo(WeatherApiResponse objCidade)
        {
            string cidade = objCidade.Location.Name;
            string path = "current?access_key=08d9721c9f4a140a938f7325c3402e41&query="+cidade;
            HttpResponseMessage response = MyHTTPClient.clientes.GetAsync(path).Result;
            string myJsonResponse = await response.Content.ReadAsStringAsync();
            WeatherApiResponse apiResponse = JsonConvert.DeserializeObject<WeatherApiResponse>(myJsonResponse);
            return View(apiResponse);
        }

        public IActionResult NovaContaBancaria(ContaBancaria MinhaNovaContaBancaria)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AddContaBancaria(MinhaNovaContaBancaria);
                return View("NovaConta", MinhaNovaContaBancaria);
            }
            else
            {
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
    }
}
