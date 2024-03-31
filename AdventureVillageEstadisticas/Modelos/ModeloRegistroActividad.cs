using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas.Modelos
{
    class ModeloRegistroActividad
    {
        private string idRegistro;
        private string idUsuario;
        private string Descripcion;
        private DateTime FechaRegistro;

        public string _idRegistro { get { return idRegistro; } set { idRegistro = value; } }
        public string _idUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string _Descripcion { get { return Descripcion; } set { Descripcion = value; } }
        public DateTime _FechaRegistro { get { return FechaRegistro; } set { FechaRegistro = value; } }

        public ModeloRegistroActividad()
        {
            idRegistro = "";
            idUsuario = "";
            Descripcion = "";
            FechaRegistro = DateTime.Now;
        }

        public ModeloRegistroActividad(string idUsuario_, string Descripcion_) : this()
        {
            idUsuario = idUsuario_;
            Descripcion = Descripcion_;
        }

        public ModeloRegistroActividad(string idRegistro_, string idUsuario_, string Descripcion_, DateTime FechaRegistro_)
        {
            idRegistro = idRegistro_;
            idUsuario = idUsuario_;
            Descripcion = Descripcion_;
            FechaRegistro = FechaRegistro_;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
