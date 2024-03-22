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

        public List<ModeloTipoArticulo> TiposArticulo()
        {
            List<ModeloTipoArticulo> ListaTipoArticulo = new List<ModeloTipoArticulo>();

            try
            {
                string query = "SELECT * FROM Tipo_Articulo";
                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    ModeloTipoArticulo TipoArticulo = new ModeloTipoArticulo();
                    TipoArticulo._idTipo_Articulo = Lectura["idTipo"].ToString();
                    TipoArticulo._Nombre_Tipo = Lectura["Nombre_Tipo"].ToString();
                    ListaTipoArticulo.Add(TipoArticulo);
                }

                Conectar.Close();
            }
            catch { }
            return ListaTipoArticulo;
        }

        public List<ModeloTipoStats> TipoStats()
        {
            List<ModeloTipoStats> ListaTipoStats = new List<ModeloTipoStats>();

            try
            {
                string query = "SELECT * FROM Tipo_Stats";
                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    ModeloTipoStats tipoStats = new ModeloTipoStats();
                    tipoStats._idTipo_Stats = Lectura["idTipo_Stats"].ToString();
                    tipoStats._Nombre_TipoS = Lectura["NombreStat"].ToString();
                    ListaTipoStats.Add(tipoStats);
                }

                Conectar.Close();
            }
            catch { }
            return ListaTipoStats;
        }

        public List<ModeloModoStats> ModoStats()
        {
            List<ModeloModoStats> ListaModoStats = new List<ModeloModoStats>();

            try
            {
                string query = "SELECT * FROM Modo_Stats";
                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    ModeloModoStats ModoStats = new ModeloModoStats();
                    ModoStats._idModo_Stats = Lectura["idModo_Stats"].ToString();
                    ModoStats._Modo_Stats = Lectura["ModoStats"].ToString();
                    ListaModoStats.Add(ModoStats);
                }

                Conectar.Close();
            }
            catch { }
            return ListaModoStats;
        }

        public List<ModeloUsuario> Usuarios()
        {
            List<ModeloUsuario> ListaUsers = new List<ModeloUsuario>();

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
                    User._Correo = Lectura["Correo"].ToString();
                    User._Fecha_Registro = Convert.ToDateTime(Lectura["Fecha_Registro"]);
                    User._Activo = Convert.ToBoolean(Lectura["Activo"]);
                    ListaUsers.Add(User);
                }

                Conectar.Close();
            }
            catch { }
            return ListaUsers;
        }

        public List<ModeloArticulos> Articulos()
        {
            List<ModeloArticulos> ListaArticulos = new List<ModeloArticulos>();

            try
            {
                string query = "SELECT a.*, ta.Nombre_Tipo, ts.NombreStat, m.ModoStats FROM Articulo a " +
                    "INNER JOIN Tipo_Articulo ta ON a.idTipo = ta.idTipo " +
                    "INNER JOIN Modo_Stats m ON a.idModo_Stats = m.idModo_Stats " +
                    "INNER JOIN Tipo_Stats ts ON a.idTipo_Stats = ts.idTipo_Stats";
                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    ModeloArticulos Articulo = new ModeloArticulos();
                    Articulo._idArticulo = Lectura["idArticulo"].ToString();
                    Articulo._NombreArticulo = Lectura["Nombre_Articulo"].ToString();
                    Articulo._URLImagen = Lectura["Url_Imagen"].ToString();
                    Articulo._Tipo = Lectura["Nombre_Tipo"].ToString();
                    Articulo._Nombre_Stat = Lectura["NombreStat"].ToString();
                    Articulo._Cantidad_Stats = Convert.ToInt32(Lectura["Cantidad_Stats"]);
                    Articulo._Modo_Stats = Lectura["ModoStats"].ToString();
                    Articulo._Activo = Convert.ToBoolean(Lectura["Activo"]);
                    ListaArticulos.Add(Articulo);
                }

                Conectar.Close();
            }
            catch { }
            return ListaArticulos;
        }

        public List<Modelos.ModeloRangoCantidad> RangoUsuariosGraficoIzq(string Desde, string Hasta, int Rango, bool Activos)
        {
            List<Modelos.ModeloRangoCantidad> Listado = new List<Modelos.ModeloRangoCantidad>();

            Desde += " 00:00:00";
            Hasta += " 23:59:59";
            try
            {
                string query = string.Empty;
                if (Rango == 0 && !Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y-%m-%d') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta GROUP BY Fecha ORDER BY Fecha;";
                }
                if (Rango == 0 && Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y-%m-%d') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta AND Activo = TRUE GROUP BY Fecha ORDER BY Fecha;";
                }
                if (Rango == 1 && !Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y-%m') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta GROUP BY Fecha ORDER BY Fecha;";
                }
                if (Rango == 1 && Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y-%m') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta AND Activo = TRUE GROUP BY Fecha ORDER BY Fecha;";
                }
                if (Rango == 2 && !Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta GROUP BY Fecha ORDER BY Fecha;";
                }
                if (Rango == 2 && Activos)
                {
                    query = "SELECT COUNT(idUsuario) AS Cantidad, DATE_FORMAT(Fecha_Registro, '%Y') AS Fecha " +
                    "FROM Usuario WHERE Fecha_Registro BETWEEN @FechaDesde AND @FechaHasta AND Activo = TRUE GROUP BY Fecha ORDER BY Fecha;";
                }

                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                ComandoSQL.Parameters.AddWithValue("@FechaDesde", Desde);
                ComandoSQL.Parameters.AddWithValue("@FechaHasta", Hasta);
                ComandoSQL.ExecuteNonQuery();
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    Modelos.ModeloRangoCantidad RangoC = new Modelos.ModeloRangoCantidad();
                    RangoC._Cantidad = Convert.ToInt32(Lectura["Cantidad"]);
                    RangoC._Rango = Lectura["Fecha"].ToString();
                    Listado.Add(RangoC);
                }

                Conectar.Close();
            }
            catch { }
            return Listado;
        }

        public List<Modelos.ModeloRangoCantidad> RangoArticulosGraficoDer(int Opcion)
        {
            List<Modelos.ModeloRangoCantidad> Listado = new List<Modelos.ModeloRangoCantidad>();
            try
            {
                string query = string.Empty;

                if (Opcion == 0) query = "SELECT COUNT(idArticulo) AS Cantidad, Nombre_Tipo AS Busqueda FROM Articulo a INNER JOIN Tipo_Articulo t ON a.idTipo = t.idTipo GROUP BY Nombre_Tipo;";
                if (Opcion == 1) query = "SELECT COUNT(idArticulo) AS Cantidad, NombreStat AS Busqueda FROM Articulo a INNER JOIN Tipo_Stats t ON a.idTipo_Stats = t.idTipo_Stats GROUP BY NombreStat;";
                if (Opcion == 2) query = "SELECT COUNT(idArticulo) AS Cantidad, ModoStats AS Busqueda FROM Articulo a INNER JOIN Modo_Stats m ON a.idModo_Stats = m.idModo_Stats GROUP BY ModoStats;";

                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                while (Lectura.Read())
                {
                    Modelos.ModeloRangoCantidad RangoC = new Modelos.ModeloRangoCantidad();
                    RangoC._Cantidad = Convert.ToInt32(Lectura["Cantidad"]);
                    RangoC._Rango = Lectura["Busqueda"].ToString();
                    Listado.Add(RangoC);
                }

                Conectar.Close();
            }
            catch { }
            return Listado;
        }

        public int CantidadTotalDe(int Indice)
        {
            string query = string.Empty;
            int cantidad = 0;

            try
            {
                switch (Indice)
                {
                    case 1:
                        query = "SELECT COUNT(idUsuario) AS Cantidad FROM Usuario;";
                        break;
                    case 2:
                        query = "SELECT COUNT(idArticulo) AS Cantidad FROM Articulo;";
                        break;
                    default:
                        break;
                }

                MySqlConnection Conectar = EstablecerConexion();
                MySqlCommand ComandoSQL = new MySqlCommand(query, Conectar);
                MySqlDataReader Lectura = ComandoSQL.ExecuteReader();

                if (Lectura.Read()) cantidad = Convert.ToInt32(Lectura["Cantidad"]);

                Conectar.Close();
            }
            catch { }
            return cantidad;
        }

        #endregion

        #region Funciones

        public void AgregarModificarTipoArticulo(ModeloTipoArticulo NewTipo, bool Modificar)
        {
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                string Query;

                if (!Modificar)
                {
                    Query = "INSERT INTO tipo_articulo (idTipo, Nombre_Tipo) " +
                            "VALUES(@idTipo, @Tipo);";
                    ConfirmarQueryTipoArticulo(Query, Conectar, NewTipo);
                }
                else
                {
                    Query = "UPDATE tipo_articulo SET Nombre_Tipo = @Tipo " +
                        "WHERE idTipo = @idTipo";
                    ConfirmarQueryTipoArticulo(Query, Conectar, NewTipo);
                }
            }
            catch { }
        }

        private void ConfirmarQueryTipoArticulo(string Query, MySqlConnection Conectar, ModeloTipoArticulo NewTipo)
        {
            using (MySqlCommand cmds = new MySqlCommand(Query, Conectar))
            {
                cmds.Parameters.AddWithValue("@idTipo", NewTipo._idTipo_Articulo);
                cmds.Parameters.AddWithValue("@Tipo", NewTipo._Nombre_Tipo);
                cmds.ExecuteNonQuery();
                Conectar.Close();
            }
        }

        public void AgregarModificarTipoStats(ModeloTipoStats NewTipo, bool Modificar)
        {
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                string Query;

                if (!Modificar)
                {
                    Query = "INSERT INTO tipo_stats (idTipo_Stats, NombreStat) " +
                            "VALUES(@idTipo, @Tipo);";
                    ConfirmarQueryTipoStats(Query, Conectar, NewTipo);
                }
                else
                {
                    Query = "UPDATE tipo_stats SET NombreStat = @Tipo " +
                        "WHERE idTipo_Stats = @idTipo";
                    ConfirmarQueryTipoStats(Query, Conectar, NewTipo);
                }
            }
            catch { }
        }

        private void ConfirmarQueryTipoStats(string Query, MySqlConnection Conectar, ModeloTipoStats NewTipo)
        {
            using (MySqlCommand cmds = new MySqlCommand(Query, Conectar))
            {
                cmds.Parameters.AddWithValue("@idTipo", NewTipo._idTipo_Stats);
                cmds.Parameters.AddWithValue("@Tipo", NewTipo._Nombre_TipoS);
                cmds.ExecuteNonQuery();
                Conectar.Close();
            }
        }

        public void AgregarModificarModoStats(ModeloModoStats NewModo, bool Modificar)
        {
            try
            {
                MySqlConnection Conectar = EstablecerConexion();
                string Query;

                if (!Modificar)
                {
                    Query = "INSERT INTO modo_stats (idModo_Stats, ModoStats) " +
                            "VALUES(@idModo, @Modo);";
                    ConfirmarQueryModoStats(Query, Conectar, NewModo);
                }
                else
                {
                    Query = "UPDATE modo_stats SET ModoStats = @Modo " +
                        "WHERE idModo_Stats = @idModo";
                    ConfirmarQueryModoStats(Query, Conectar, NewModo);
                }
            }
            catch { }
        }

        private void ConfirmarQueryModoStats(string Query, MySqlConnection Conectar, ModeloModoStats NewModo)
        {
            using (MySqlCommand cmds = new MySqlCommand(Query, Conectar))
            {
                cmds.Parameters.AddWithValue("@idModo", NewModo._idModo_Stats);
                cmds.Parameters.AddWithValue("@Modo", NewModo._Modo_Stats);
                cmds.ExecuteNonQuery();
                Conectar.Close();
            }
        }

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
                    Query = "INSERT INTO Usuario (idUsuario, idRol, Contraseña, Correo, Fecha_Registro, Activo) VALUES" +
                        "(@idUsuario, @idRol, @Contraseña, @Correo, @FechaRegistro, @Activo);";
                    ConfirmarQueryUsuario(Query, Conectar, NewUser);
                }
                else
                {
                    Query = "UPDATE Usuario SET idRol = @idRol, Contraseña = @Contraseña, Correo = @Correo, Fecha_Registro = @FechaRegistro, Activo = @Activo WHERE idUsuario = @idUsuario;";
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
                cmds.Parameters.AddWithValue("@Correo", NewUser._Correo);
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

        public void AgregarModificarArticulo(ModeloArticulos NewArticulo, bool Nuevo)
        {
            try
            {
                List<ModeloTipoArticulo> T_Articulos = TiposArticulo();
                List<ModeloTipoStats> T_Stats = TipoStats();
                List<ModeloModoStats> M_Stats = ModoStats();

                for (int i = 0; i < T_Articulos.Count; i++)
                {
                    if (NewArticulo._Tipo == T_Articulos[i]._Nombre_Tipo)
                    {
                        NewArticulo._Tipo = T_Articulos[i]._idTipo_Articulo;
                        break;
                    }
                }

                for (int i = 0; i < T_Stats.Count; i++)
                {
                    if (NewArticulo._Nombre_Stat == T_Stats[i]._Nombre_TipoS)
                    {
                        NewArticulo._Nombre_Stat = T_Stats[i]._idTipo_Stats;
                        break;
                    }
                }
                for (int i = 0; i < M_Stats.Count; i++)
                {
                    if (NewArticulo._Modo_Stats == M_Stats[i]._Modo_Stats)
                    {
                        NewArticulo._Modo_Stats = M_Stats[i]._idModo_Stats;
                        break;
                    }
                }

                MySqlConnection Conectar = EstablecerConexion();
                string Query;

                if (Nuevo)
                {
                    Query = "INSERT INTO Articulo (idArticulo, Nombre_Articulo, Url_Imagen, idTipo, idTipo_Stats, Cantidad_Stats, idModo_Stats, Activo) VALUES " +
                        "(@idArticulo, @Nombre_Articulo, @Url_Imagen, @idTipo, @idTipo_Stats, @Cantidad_Stats, @idModo_Stats, @Activo);";
                    ConfirmarQueryArticulo(Query, Conectar, NewArticulo);
                }
                else
                {
                    Query = "UPDATE Articulo SET Nombre_Articulo = @Nombre_Articulo, Url_Imagen = @Url_Imagen, idTipo = @idTipo, idTipo_Stats = @idTipo_Stats," +
                        " Cantidad_Stats = @Cantidad_Stats, idModo_Stats = @idModo_Stats, Activo = @Activo WHERE idArticulo = @idArticulo";
                    ConfirmarQueryArticulo(Query, Conectar, NewArticulo);
                }
            }
            catch { }
        }

        private void ConfirmarQueryArticulo(string Query, MySqlConnection Conectar, ModeloArticulos NewArticulo)
        {
            using (MySqlCommand cmds = new MySqlCommand(Query, Conectar))
            {
                cmds.Parameters.AddWithValue("@idArticulo", NewArticulo._idArticulo);
                cmds.Parameters.AddWithValue("@Nombre_Articulo", NewArticulo._NombreArticulo);
                cmds.Parameters.AddWithValue("@Url_Imagen", NewArticulo._URLImagen);
                cmds.Parameters.AddWithValue("@idTipo", NewArticulo._Tipo);
                cmds.Parameters.AddWithValue("@idTipo_Stats", NewArticulo._Nombre_Stat);
                cmds.Parameters.AddWithValue("@Cantidad_Stats", NewArticulo._Cantidad_Stats);
                cmds.Parameters.AddWithValue("@idModo_Stats", NewArticulo._Modo_Stats);
                cmds.Parameters.AddWithValue("@Activo", NewArticulo._Activo);
                cmds.ExecuteNonQuery();
                Conectar.Close();
            }
        }

        public void OcultarArticulo(string idArticulo, bool Activo)
        {
            try
            {
                string query;
                if (Activo) query = "UPDATE Articulo SET Activo = FALSE WHERE idArticulo = @idArticulo;";
                else query = "UPDATE Articulo SET Activo = TRUE WHERE idArticulo = @idArticulo;";
                MySqlConnection Conectar = EstablecerConexion();

                using (MySqlCommand cmds = new MySqlCommand(query, Conectar))
                {
                    cmds.Parameters.AddWithValue("@idArticulo", idArticulo);
                    cmds.ExecuteNonQuery();
                    Conectar.Close();
                }
            }
            catch { }
        }

        #endregion

    }
}
