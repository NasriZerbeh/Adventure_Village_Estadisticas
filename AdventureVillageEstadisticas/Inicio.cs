using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureVillageEstadisticas
{
    public partial class Inicio : MaterialForm
    {
        private ConexionBD Conectar;
        public Inicio()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Conectar = new ConexionBD();
            Conectar.EstablecerConexion();
        }
    }
}
