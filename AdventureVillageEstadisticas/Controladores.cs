using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace AdventureVillageEstadisticas
{
    class Controladores : ConexionBD
    {
        public List<ModeloRoles> Roles()
        {
            List<ModeloRoles> ListaRoles = new List<ModeloRoles>();
            string query = "SELECT * FROM Rol";

            MySqlConnection Conectar = EstablecerConexion();
            MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
            MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

            while(Lectura.Read())
            {
                ModeloRoles Roles = new ModeloRoles();
                Roles._idRol = Lectura["idRol"].ToString();
                Roles._Rol = Lectura["Rol"].ToString();
                ListaRoles.Add(Roles);
            }

            Conectar.Close();

            return ListaRoles;
        }

        public List<ModeloUsuario> Usuarios()
        {
            List<ModeloUsuario> ListaRoles = new List<ModeloUsuario>();
            string query = "SELECT u.*, r.Rol FROM Usuario u INNER JOIN Rol r ON u.idRol = r.idRol";

            MySqlConnection Conectar = EstablecerConexion();
            MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
            MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

            while (Lectura.Read())
            {
                ModeloUsuario User = new ModeloUsuario();
                User._idUsuario = Lectura["idUsuario"].ToString();
                User._idRol = Lectura["Rol"].ToString();
                User._Contraseña = Lectura["Contraseña"].ToString();
                User._Fecha_Registro = Convert.ToDateTime(Lectura["Fecha_Registro"]);
                ListaRoles.Add(User);
            }

            Conectar.Close();

            return ListaRoles;
        }
    }
}
