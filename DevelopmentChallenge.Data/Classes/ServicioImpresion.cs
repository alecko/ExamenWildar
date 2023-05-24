using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class ServicioImpresion
    {

        public static string Imprimir(List<IFormaGeometrica> formas, string cultura)
        {
            Resources.Culture = new CultureInfo(cultura);
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{Resources.MensajeVacio}</h1>");
            }
            else
            {
                sb.Append($"<h1>{Resources.Encabezado}</h1>");

                var resultados = formas.GroupBy(f => new { f.GetType().Name })
                    .Select(g => new
                    {
                        Forma = g.Key.Name,
                        Cantidad = g.Count(),
                        Areas = g.Sum(f => f.CalcularArea()),
                        Perimetros = g.Sum(f => f.CalcularPerimetro())
                    }).ToList();

                foreach (var res in resultados)
                {
                    //sb.Append($"{Resources.nameof(res.Forma)} - {Resources.LabelCantidad}: {res.Cantidad} {Resources.LabelArea}: {res.Areas}, {Resources.LabelPerimetro}: {res.Perimetros}");
                    sb.Append($"{res.Forma} - {Resources.LabelCantidad}: {res.Cantidad} {Resources.LabelArea}: {res.Areas}, {Resources.LabelPerimetro}: {res.Perimetros}");
                }

                sb.Append($"{Resources.Footer}:</br>");
                sb.Append($"{formas.Count} {Resources.Formas}");
                sb.Append($" - {Resources.LabelPerimetro} {resultados.Sum(r => r.Perimetros)} ");
                sb.Append($" - {Resources.LabelArea} {resultados.Sum(r => r.Areas)} ");
            }

            return sb.ToString();
        }

    }
}
