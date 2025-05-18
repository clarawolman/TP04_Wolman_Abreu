using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Wolman_Abreu.Models;

namespace TP04_Wolman_Abreu.Controllers;

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

    public IActionResult Jugar()
    {
        Ahorcado.ReiniciarJuego();
        ViewBag.Ahorcado = Ahorcado.ListaNuevaAhorcado();
        return View("Jugar");
    }
    public IActionResult ArriesgarLetra(char letra)
    {
        ViewBag.Ahorcado = Ahorcado.ArriesgarLetra(letra);
        ViewBag.LetraArriesgada = letra;
        ViewBag.LetrasArriesgadas = Ahorcado.DevolverArriesgadas();
        ViewBag.GanarPerder = Ahorcado.ComprobarGanar();
        return View("Jugar");
    }
    public IActionResult ArriesgarPalabra(string palabra)
    {
        ViewBag.Palabra = Ahorcado.RandomPalabra();
        ViewBag.AdivinoPalabra = Ahorcado.ArriesgarPalabra(palabra);
        ViewBag.PalabraArriesgada = palabra;
        return View("Jugar");
    }
}