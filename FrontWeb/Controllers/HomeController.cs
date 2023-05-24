using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontWeb.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(2),
                new Circulo(4),
                new Circulo(6),
                new Rectangulo(3,6),
                new Rectangulo(2,4),
                new TrianguloEquilatero(4),
                new Trapecio(10,5,5,5,7)
            };

            //Aca se selecciona el idioma de acuerdo a la cultura que queramos
            //var resumen = ServicioImpresion.Imprimir(formas, "it-IT");
            //var resumen = ServicioImpresion.Imprimir(formas, "es-ES");
            var resumen = ServicioImpresion.Imprimir(formas);

            return resumen;
        }

    }
}