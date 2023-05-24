/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace ExecChallenge
{
    internal class Program
    {
        static void Main(string[] args)
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
            };

            var resumen = ServicioImpresion.Imprimir(formas, "es-ES");
            Console.Write(resumen);
            //resumen = ServicioImpresion.Imprimir(formas, "it-IT");
            //Console.Write(resumen);
            //var resumen = ServicioImpresion.Imprimir(formas, CultureInfo.CurrentCulture.Name);
            //Console.Write(resumen);

            Console.ReadLine();
        }
    }
}
