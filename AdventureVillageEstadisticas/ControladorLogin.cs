using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ControladorLogin : ConexionBD
    {
        public bool IniciarSesion(string User, string Password)
        {
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                MySqlDataReader Lectura;
                string query = "SELECT idUsuario FROM Usuario WHERE idUsuario = @idUduario AND Contraseña = @Contraseña;";

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idUsuario", User);
                    cmds.Parameters.AddWithValue("@Contraseña", Password);
                    cmds.ExecuteNonQuery();
                    Lectura = cmds.ExecuteReader();
                }

                if (Lectura.Read()) return true;
                else return false;
            }
            catch { return false; }
        }

        public string[] RolUser(string User)
        {
            string[] UsuarioIngresado = new string[2] { "", "" };
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                MySqlDataReader Lectura;
                string query = "SELECT u.idUsuario, r.Rol FROM Usuario u INNER JOIN Rol r ON u.idUsuario = r.idUsuario " +
                    "WHERE idUsuario = @idUduario;";

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idUsuario", User);
                    cmds.ExecuteNonQuery();
                    Lectura = cmds.ExecuteReader();
                }

                if (Lectura.Read())
                {
                    UsuarioIngresado[0] = Lectura["idUsuario"].ToString();
                    UsuarioIngresado[1] = Lectura["Rol"].ToString();
                }
                return UsuarioIngresado;
            }
            catch { return UsuarioIngresado; }
        }
    }
}
