using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloUsuario
    {
        private string idUsuario;
        private string idRol;
        private string Contraseña;
        private string Correo;
        private DateTime Fecha_Registro;
        private bool Activo;

        public string _idUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string _idRol { get { return idRol; } set { idRol = value; } }
        public string _Contraseña { get { return Contraseña; } set { Contraseña = value; } }
        public string _Correo { get { return Correo; } set { Correo = value; } }
        public DateTime _Fecha_Registro { get { return Fecha_Registro; } set { Fecha_Registro = value; } }
        public bool _Activo { get { return Activo; } set { Activo = value; } }

        public ModeloUsuario()
        {
            idUsuario = "";
            idRol = "";
            Contraseña = "";
            Correo = "";
            Fecha_Registro = DateTime.Now;
            Activo = true;
        }

        public ModeloUsuario(string idUsuario_, string idRol_, string Contraseña_, string Correo_) : this()
        {
            idUsuario = idUsuario_;
            idRol = idRol_;
            Contraseña = Contraseña_;
            Correo = Correo_;
        }

        public ModeloUsuario(string idUsuario_, string idRol_, string Contraseña_, string Correo_, DateTime Fecha_Registro_, bool Activo_)
        {
            idUsuario = idUsuario_;
            idRol = idRol_;
            Contraseña = Contraseña_;
            Correo = Correo_;
            Fecha_Registro = Fecha_Registro_;
            Activo = Activo_;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
