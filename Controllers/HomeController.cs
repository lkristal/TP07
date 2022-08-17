using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP7.Models;

namespace TP7.Controllers
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

        public IActionResult Player()
        {
            return View("Jugar");
        }

        public IActionResult FinJuego()
        {
            return View("PantallaFindelJuego");
        }

        [HttpGet]
        public IActionResult Jugar(string Nombre)
        {
            JuegoQQSM.IniciarJuego(Nombre);
            return RedirectToAction("Pregunta","Home");
        }

        public IActionResult Pregunta()
        {
            ViewBag.Pregunta = JuegoQQSM.ObtenerProximaPregunta();
            ViewBag.Respuestas = JuegoQQSM.ObtenerRespuestas();
            ViewBag.ListaPozo = JuegoQQSM.DevolverListaPozo();
            ViewBag.Player = JuegoQQSM.DevolverJugador();
            ViewBag.ImportePozo = ViewBag.ListaPozo[JuegoQQSM.DevolverPosicionPozo()].Importe;
            return View("Pregunta");
        }

        public IActionResult PreguntaRespondida(char Opcion1)
        {
            if (JuegoQQSM.RespuestaUsuario(Opcion1))
            {
                List<Pozo> ListaPozo = JuegoQQSM.DevolverListaPozo();
                ViewBag.Pozo = ListaPozo[JuegoQQSM.DevolverPosicionPozo()];

                return View("RespuestaPreguntaOK");
            }
            else
            {
                return View("PantallaFindelJuego");
            }
            
        }
        [HttpPost]
        public IActionResult ResponderDobleChance(char A, char B, char C, char D)
        {
            
            return View();
        }

        public IActionResult Comodin50()
        {
            ViewBag.Pregunta = JuegoQQSM.ObtenerProximaPregunta();
            ViewBag.Respuestas = JuegoQQSM.ObtenerRespuestas();
            ViewBag.ListaPozo = JuegoQQSM.DevolverListaPozo();
            ViewBag.DescartarRespuestas = JuegoQQSM.DescartarComodin50();
            ViewBag.Player = JuegoQQSM.DevolverJugador();
            return View("Pregunta");
        }
        
        public IActionResult ComodinSaltear()
        {
            JuegoQQSM.SaltearPregunta();
            return RedirectToAction("Pregunta","Home");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
