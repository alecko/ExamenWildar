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

        public static string Imprimir(List<IFormaGeometrica> formas, string cultura="")
        {
         //   Resources.Culture = new CultureInfo(cultura);
            ResourceManager rm = new ResourceManager(typeof(Resources));
            ResourceSet rs = rm.GetResourceSet(CultureInfo.CreateSpecificCulture(cultura), true, true);
            
            var sb = new StringBuilder();
            
            if (!formas.Any())
            {
                sb.Append($"<h1>{rs.GetString("MensajeVacio")}</h1>");
            }
            else
            {
                sb.Append($"<h1>{rs.GetString("Encabezado")}</h1>");

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
                    sb.Append($"{rs.GetString(res.Forma)} - {rs.GetString("LabelCantidad")}: {res.Cantidad} {rs.GetString("LabelArea")}: {res.Areas.ToString("#.##")}, {rs.GetString("LabelPerimetro")}: {res.Perimetros.ToString("#.##")}</br>");
                }

                sb.Append($"<h1>{rs.GetString("Footer")}:</h1>");
                sb.Append($"{formas.Count} {rs.GetString("Formas")}");
                sb.Append($" - {rs.GetString("LabelPerimetro")} {resultados.Sum(r => r.Perimetros).ToString("#.##")} ");
                sb.Append($" - {rs.GetString("LabelArea")} {resultados.Sum(r => r.Areas).ToString("#.##")} ");
            }

            return sb.ToString();
        }

    }
}
