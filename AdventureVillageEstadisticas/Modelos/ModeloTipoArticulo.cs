using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloTipoArticulo
    {
        private string idTipo_Articulo;
        private string Nombre_Tipo;

        public string _idTipo_Articulo { get { return idTipo_Articulo; } set { idTipo_Articulo = value; } }
        public string _Nombre_Tipo { get { return Nombre_Tipo; } set { Nombre_Tipo = value; } }

        public ModeloTipoArticulo()
        {
            idTipo_Articulo = "";
            Nombre_Tipo = "";
        }

        public ModeloTipoArticulo(string Codigo, string Nombre)
        {
            idTipo_Articulo = Codigo;
            Nombre_Tipo = Nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
