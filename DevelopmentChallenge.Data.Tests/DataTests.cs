using System;
using System.Collections.Generic;
using System.Linq;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list!!</h1>",
                ServicioImpresion.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestPerimetroUnCuadrado()
        {
            var perimetroCuadrado = new Cuadrado(5).CalcularPerimetro();

            Assert.AreEqual(perimetroCuadrado, 20m);
        }

        [TestCase]
        public void TestAreaUnCuadrado()
        {
            var areaCuadrado = new Cuadrado(5).CalcularArea();

            Assert.AreEqual(areaCuadrado, 25m);
        }

        [TestCase]
        public void TestPerimetroListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };

            var perimetros = cuadrados.Sum(c => c.CalcularPerimetro());

            Assert.AreEqual(perimetros, 36);
        }
        
    }
}
