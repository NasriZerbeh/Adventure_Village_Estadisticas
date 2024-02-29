using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloModoStats
    {
        private string idModo_Stats;
        private string Modo_Stats;

        public string _idModo_Stats { get { return idModo_Stats; } set { idModo_Stats = value; } }
        public string _Modo_Stats { get { return Modo_Stats; } set { Modo_Stats = value; } }

        public ModeloModoStats()
        {
            idModo_Stats = "";
            Modo_Stats = "";
        }

        public ModeloModoStats(string Codigo, string Nombre)
        {
            idModo_Stats = Codigo;
            Modo_Stats = Nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
