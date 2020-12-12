using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalOpcion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FinalOpcion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumerosController : ControllerBase
    {
        [HttpGet]
        public string Operacion(int numero) {
            string palabra = "";
            if (numero < 0)
            {
                palabra = "ERROR";
            }
            else
            {
                if (numero == 0)
                {
                    palabra = "Realizado por Angelica Isabel Cladera Melgar";
                }
                else
                {
                    palabra = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
                }
            }
            return palabra;

        }
        [HttpPost]
        public string Operacion2([FromHeader]int numero)
        {
            string palabra = "";
            if (numero < 0)
            {
                palabra = "ERROR";
            }
            else
            {
                if (numero == 0)
                {
                    palabra = "Realizado por Angelica Isabel Cladera Melgar";
                }
                else
                {
                    palabra = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
                }
            }
            return palabra;

        }
    }
}
