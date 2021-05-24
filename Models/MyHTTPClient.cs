using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
    public class MyHTTPClient
    {
        private static string baseAddress = "http://api.weatherstack.com/";
        private static HttpClient cliente;

        public static HttpClient clientes
        {
            get
            {
                if (cliente == null)
                {
                    cliente = new HttpClient();
                    cliente.BaseAddress = new Uri(baseAddress);
                    cliente.DefaultRequestHeaders.Accept.Clear();
                    cliente.DefaultRequestHeaders.Accept.Add(new
                    MediaTypeWithQualityHeaderValue("application/json"));
                }
                return cliente;
            }
        }

        internal static object GetAsync(string path)
        {
            throw new NotImplementedException();
        }
    }
    }



