using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloArticulos
    {
        private string idArticulo;
        private string NombreArticulo;
        private string URLImagen;
        private string Tipo;

        public string _idArticulo { get { return idArticulo; } set { idArticulo = value; } }
        public string _NombreArticulo { get { return NombreArticulo; } set { NombreArticulo = value; } }
        public string _URLImagen { get { return URLImagen; } set { URLImagen = value; } }
        public string _Tipo { get { return Tipo; } set { Tipo = value; } }

        public ModeloArticulos()
        {
            idArticulo = "";
            NombreArticulo = "";
            URLImagen = "";
            Tipo = "";
        }

        public ModeloArticulos(string idArticulo_, string NombreArticulo_, string URLImagen_, string Tipo_)
        {
            idArticulo = idArticulo_;
            NombreArticulo = NombreArticulo_;
            URLImagen = URLImagen_;
            Tipo = Tipo_;
        }
    }
}
