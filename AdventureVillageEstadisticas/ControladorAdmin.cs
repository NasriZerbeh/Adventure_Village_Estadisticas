using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace AdventureVillageEstadisticas
{
    class ControladorAdmin : ConexionBD
    {
        #region Retornar Listas de objetos

        public List<ModeloRoles> Roles()
        {
            List<ModeloRoles> ListaRoles = new List<ModeloRoles>();

            try
            {
                string query = "SELECT * FROM Rol";
                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    ModeloRoles Roles = new ModeloRoles();
                    Roles._idRol = Lectura["idRol"].ToString();
                    Roles._Rol = Lectura["Rol"].ToString();
                    ListaRoles.Add(Roles);
                }

                Conectar.Close();
            }
            catch { }
            return ListaRoles;
        }

        public List<ModeloUsuario> Usuarios()
        {
            List<ModeloUsuario> ListaRoles = new List<ModeloUsuario>();

            try
            {
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
                    User._Activo = Convert.ToBoolean(Lectura["Activo"]);
                    ListaRoles.Add(User);
                }

                Conectar.Close();
            }
            catch { }
            return ListaRoles;
        }

        #endregion

        #region Funciones

        public void AgregarModificarUsuario(ModeloUsuario NewUser, bool Nuevo)
        {
            try
            {
                List<ModeloRoles> Rols = Roles();
                MySqlConnection Conectar = EstablecerConexion();
                string Query;

                for (int i = 0; i < Rols.Count; i++)
                {
                    if (NewUser._idRol == Rols[i]._Rol)
                    {
                        NewUser._idRol = Rols[i]._idRol;
                        break;
                    }
                }

                if (Nuevo)
                {
                    Query = "INSERT INTO Usuario (idUsuario, idRol, Contraseña, Fecha_Registro, Activo) VALUES" +
                        "(@idUsuario, @idRol, @Contraseña, @FechaRegistro, @Activo);";
                    ConfirmarQueryUsuario(Query, Conectar, NewUser);
                }
                else
                {
                    Query = "UPDATE Usuario SET idRol = @idRol, Contraseña = @Contraseña, Fecha_Registro = @FechaRegistro, Activo = @Activo WHERE idUsuario = @idUsuario;";
                    ConfirmarQueryUsuario(Query, Conectar, NewUser);
                }
            }
            catch { }
        }

        private void ConfirmarQueryUsuario(string Query, MySqlConnection Conectar, ModeloUsuario NewUser)
        {
            using (MySqlCommand cmds = new MySqlCommand(Query, Conectar))
            {
                cmds.Parameters.AddWithValue("@idUsuario", NewUser._idUsuario);
                cmds.Parameters.AddWithValue("@idRol", NewUser._idRol);
                cmds.Parameters.AddWithValue("@Contraseña", NewUser._Contraseña);
                cmds.Parameters.AddWithValue("@FechaRegistro", NewUser._Fecha_Registro);
                cmds.Parameters.AddWithValue("@Activo", NewUser._Activo);
                cmds.ExecuteNonQuery();
                Conectar.Close();
            }
        }

        public void BloqueoUsuario(string idUsuario, bool Activo)
        {
            try
            {
                string query;
                if (Activo) query = "UPDATE Usuario SET Activo = FALSE WHERE idUsuario = @idUsuario;";
                else query = "UPDATE Usuario SET Activo = TRUE WHERE idUsuario = @idUsuario;";
                MySqlConnection Conectar = EstablecerConexion();

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmds.ExecuteNonQuery();
                    Conectar.Close();
                }
            }
            catch { }
        }

        #endregion

    }
}
