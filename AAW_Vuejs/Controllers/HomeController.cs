using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AAW_Vuejs.Models;
using System.Net;

namespace AAW_Vuejs.Controllers
{
    public class HomeController : Controller
    {
        public static string URLCalculator = "http://localhost:62367/api/";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public double RealizarCalculo(double Valor1, double Valor2, string Operacao)
        {
            return CallAPI(Valor1, Valor2, Operacao);
        }

        public double CallAPI(double Valor1, double Valor2, string Operacao)
        {
            switch (Operacao)
            {
                case "som": return Calculate(Valor1, Valor2, "Sum");
                case "sub": return Calculate(Valor1, Valor2, "Subtract");
                case "mult": return Calculate(Valor1, Valor2, "Multiply");
                case "div": return Calculate(Valor1, Valor2, "Divide");
                default:
                    return 0;
            }
        }

        public double Calculate(double Valor1, double Valor2, string Operacao)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = URLCalculator;
                var json = webClient.DownloadString($"{Operacao}/{Valor1}/{Valor2}");
                return Convert.ToDouble(json);
            }
        }
    }

}
