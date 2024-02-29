using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloRoles
    {
        private string idRol;
        private string Rol;

        public string _idRol { get { return idRol; } set { idRol = value; } }
        public string _Rol { get { return Rol; } set { Rol = value; } }

        public ModeloRoles()
        {
            idRol = "";
            Rol = "";
        }

        public ModeloRoles(string Codigo, string Nombre)
        {
            idRol = Codigo;
            Rol = Nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
