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
    public partial class InterfazCarga : Form
    {
        public InterfazCarga()
        {
            InitializeComponent();
        }

        #region Botones

        private void IconoPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funciones

        public void Bienvenida(string rol, string user)
        {
            LabelRol.Text = rol;
            LabelNombre.Text = user;
            PanelCargando.Visible = true;
            if (rol == "Administrador") Permisos = true;
            this.Show();
            TerminarCarga.Start();
        }

        public void Descanso()
        {
            LabelBienvenida.Text = "Descansando";
            LabelNombre.Text = "";
            LabelRol.Text = "";
            LabelWait.Text = "ZzzZzzZzz...";
            PanelCargando.Visible = true;
            IconoPlay.Visible = true;
        }

        #endregion

        #region Eventos Adicionales

        private bool Permisos = false;

        private void TerminarCarga_Tick(object sender, EventArgs e)
        {
            if(Permisos)
            {
                ModuloAdministrador Admin = new ModuloAdministrador();
                Admin.Show();
                this.Close();
            }
            else
            {
                ModuloAdministrador Admin = new ModuloAdministrador();
                Admin.Show();
                this.Close();
            }
            TerminarCarga.Stop();
        }

        #endregion

    }
}
