using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureVillageEstadisticas
{
    class ConexionBD
    {
		private MySqlConnection conexion = new MySqlConnection();
		private string server = "localhost";
		private string database = "bdadventure";
		private string user = "root";
		private string password = "As192837465.";
		private string puerto = "3306";
		private string CadenaConexion;


		public ConexionBD()
		{
			CadenaConexion = "server=" + server +
							 "; port=" + puerto +
							 "; user id=" + user +
							 "; password=" + password +
							 "; database=" + database + ";";
		}

		public MySqlConnection EstablecerConexion()
		{
			try
			{
				conexion.ConnectionString = CadenaConexion;
				conexion.Open();
				MessageBox.Show("Exito");
			}
			catch (MySqlException e)
            {
				MessageBox.Show("Error: " + e.ToString());
            }

			return conexion;
		}
	}
}
