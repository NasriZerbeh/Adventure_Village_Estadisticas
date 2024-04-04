using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas.Controladores
{
    class ControladorRegistro : ConexionBD
    {
        public bool ConfirmarRegistro(ModeloUsuario Registro)
        {
            string query = "SELECT idUsuario FROM usuario WHERE idUsuario = @Usuario;";

            MySqlConnection Conectar = EstablecerConexion();
            MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
            ComandoSQL.Parameters.AddWithValue("@Usuario", Registro._idUsuario);
            ComandoSQL.ExecuteNonQuery();
            MySqlDataReader Lectura = ComandoSQL.ExecuteReader();
            if (Lectura.Read())
            {
                Conectar.Close();
                return false;
            }
            else
            {
                Conectar.Close();
                MySqlConnection NewConectar = EstablecerConexion();
                query = "INSERT INTO Usuario (idUsuario, idRol, Contraseña, Correo, Fecha_Registro, Activo) VALUES " +
                        "(@idUsuario, @idRol, @Contraseña, @Correo, @FechaRegistro, @Activo);";

                MySqlCommand NewComandoSQL = new MySqlCommand(query, NewConectar);

                NewComandoSQL.Parameters.AddWithValue("@idUsuario", Registro._idUsuario);
                NewComandoSQL.Parameters.AddWithValue("@idRol", Registro._idRol);
                NewComandoSQL.Parameters.AddWithValue("@Contraseña", Registro._Contraseña);
                NewComandoSQL.Parameters.AddWithValue("@Correo", Registro._Correo);
                NewComandoSQL.Parameters.AddWithValue("@FechaRegistro", Registro._Fecha_Registro);
                NewComandoSQL.Parameters.AddWithValue("@Activo", Registro._Activo);
                NewComandoSQL.ExecuteNonQuery();
                NewConectar.Close();
                ControladorAdmin Perfil = new ControladorAdmin();
                Perfil.CrearPerfilNuevo(Registro);
                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(Registro._idUsuario, "Se ha registrado por la interfaz de Login exitosamente.");
                ControladorAdmin GuardarBitacora = new ControladorAdmin();
                GuardarBitacora.AñadirBitacora(Bitacora);
                return true;
            }

        }
    }
}
