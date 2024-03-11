using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Diagnostics;

namespace AdventureVillageEstadisticas.Controladores
{
    class Reportes
    {
        private void GuardarReporte(string Ruta, string Contenido)
        {
            using (FileStream Stream = new FileStream(Ruta, FileMode.Create))
            {
                Document PDF = new Document(PageSize.LETTER, 25, 30, 25, 30);
                PdfWriter PDFW = PdfWriter.GetInstance(PDF, Stream);
                PDF.Open();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoNegro, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.ScaleToFit(100, 100);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                img.SetAbsolutePosition(PDF.LeftMargin + 20, PDF.TopMargin + 660);
                PDF.Add(img);
                using (StringReader Reader = new StringReader(Contenido))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(PDFW, PDF, Reader);
                    Process.Start(Ruta);
                }
                PDF.Close();
                Stream.Close();
            }
        }

        public void ReporteUsuarios(string Ruta, List<ModeloUsuario> Usuarios)
        {
            string Contenido = Properties.Resources.ReportesPagina.ToString();
            Contenido = Contenido.Replace("@Fecha", DateTime.Now.ToString("d"));
            Contenido = Contenido.Replace("@Hora", DateTime.Now.ToString("T"));
            string filas = string.Empty;
            int Cantidad = 0;
            foreach (var Users in Usuarios)
            {
                filas += "<tr>";
                filas += "<td style=\"width: 20 %;\">" + Users._idUsuario + "</td>";
                filas += "<td style=\"width: 20 %;\">" + Users._idRol + "</td>";
                filas += "<td style=\"width: 20 %;\">" + Users._Correo + "</td>";
                filas += "<td style=\"width: 20 %;\">" + Users._Fecha_Registro.ToString() + "</td>";
                if (Users._Activo) filas += "<td style=\"width: 20 %;\">Si</td>";
                else filas += "<td style=\"width: 20 %;\">No</td>";
                filas += "</tr>";
                Cantidad++;
            }
            Contenido = Contenido.Replace("@Filas", filas);
            Contenido = Contenido.Replace("@Cantidad", Cantidad.ToString());
            GuardarReporte(Ruta, Contenido);
        }

    }
}
