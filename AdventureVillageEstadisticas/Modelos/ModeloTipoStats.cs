using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloTipoStats
    {
        private string idTipo_Stats;
        private string Nombre_TipoS;

        public string _idTipo_Stats { get { return idTipo_Stats; } set { idTipo_Stats = value; } }
        public string _Nombre_TipoS { get { return Nombre_TipoS; } set { Nombre_TipoS = value; } }

        public ModeloTipoStats()
        {
            idTipo_Stats = "";
            Nombre_TipoS = "";
        }

        public ModeloTipoStats(string Codigo, string Nombre)
        {
            idTipo_Stats = Codigo;
            Nombre_TipoS = Nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
