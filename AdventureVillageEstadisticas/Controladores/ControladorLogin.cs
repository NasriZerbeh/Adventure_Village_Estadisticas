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
        public string IniciarSesion(string User, string Password)
        {
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                MySqlDataReader Lectura;
                string query = "SELECT Activo FROM Usuario WHERE idUsuario = @idUsuario AND Contraseña = @Contraseña;";

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idUsuario", User);
                    cmds.Parameters.AddWithValue("@Contraseña", Password);
                    cmds.ExecuteNonQuery();
                    Lectura = cmds.ExecuteReader();
                }

                if (Lectura.Read())
                {
                    if (Convert.ToBoolean(Lectura["Activo"]))
                    {
                        Conectar.Close();
                        return "Exito";
                    }
                    else return "Usuario Bloqueado";
                }
                else return "Datos incorrectos";
            }
            catch { return "No hay conexión"; }
        }

        public string[] RolUser(string User)
        {
            string[] UsuarioIngresado = new string[2] { "", "" };
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                MySqlDataReader Lectura;
                string query = "SELECT u.idUsuario, r.Rol FROM Usuario u INNER JOIN Rol r ON u.idRol = r.idRol " +
                    "WHERE idUsuario = @idUsuario;";

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idUsuario", User);
                    cmds.ExecuteNonQuery();
                    Lectura = cmds.ExecuteReader();
                }

                if (Lectura.Read())
                {
                    UsuarioIngresado[0] = Lectura["Rol"].ToString();
                    UsuarioIngresado[1] = Lectura["idUsuario"].ToString();
                    Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(UsuarioIngresado[1], "Ha iniciado sesión.");
                    ControladorAdmin GuardarBitacora = new ControladorAdmin();
                    GuardarBitacora.AñadirBitacora(Bitacora);
                }
                return UsuarioIngresado;
            }
            catch { return UsuarioIngresado; }
        }
    }
}
