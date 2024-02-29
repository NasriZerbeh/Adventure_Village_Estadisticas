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
        private string Nombre_Stat;
        private int Cantidad_Stats;
        private string Modo_Stats;
        private bool Activo;

        public string _idArticulo { get { return idArticulo; } set { idArticulo = value; } }
        public string _NombreArticulo { get { return NombreArticulo; } set { NombreArticulo = value; } }
        public string _URLImagen { get { return URLImagen; } set { URLImagen = value; } }
        public string _Tipo { get { return Tipo; } set { Tipo = value; } }
        public string _Nombre_Stat { get { return Nombre_Stat; } set { Nombre_Stat = value; } }
        public int _Cantidad_Stats { get { return Cantidad_Stats; } set { Cantidad_Stats = value; } }
        public string _Modo_Stats { get { return Modo_Stats; } set { Modo_Stats = value; } }
        public bool _Activo { get { return Activo; } set { Activo = value; } }

        public ModeloArticulos()
        {
            idArticulo = "";
            NombreArticulo = "";
            URLImagen = "";
            Tipo = "";
            Nombre_Stat = "";
            Cantidad_Stats = 0;
            Modo_Stats = "";
            Activo = true;
        }

        public ModeloArticulos(string idArticulo_, string NombreArticulo_, string URLImagen_, string Tipo_, string Nombre_Stat_, int Cantidad_Stats_, string Modo_Stats_) : this()
        {
            idArticulo = idArticulo_;
            NombreArticulo = NombreArticulo_;
            URLImagen = URLImagen_;
            Tipo = Tipo_;
            Nombre_Stat = Nombre_Stat_;
            Cantidad_Stats = Cantidad_Stats_;
            Modo_Stats = Modo_Stats_;
        }

        public ModeloArticulos(string idArticulo_, string NombreArticulo_, string URLImagen_, string Tipo_, string Nombre_Stat_, int Cantidad_Stats_, string Modo_Stats_, bool Activo_)
        {
            idArticulo = idArticulo_;
            NombreArticulo = NombreArticulo_;
            URLImagen = URLImagen_;
            Tipo = Tipo_;
            Nombre_Stat = Nombre_Stat_;
            Cantidad_Stats = Cantidad_Stats_;
            Modo_Stats = Modo_Stats_;
            Activo = Activo_;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
