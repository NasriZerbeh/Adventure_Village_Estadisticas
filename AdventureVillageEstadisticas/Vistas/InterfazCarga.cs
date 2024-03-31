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
            LabelBienvenida.Text = "Bienvenido/a";
            LabelRol.Text = rol;
            LabelNombre.Text = user;
            Usuario = user;
            LabelWait.Text = "Por favor espere un momento...";
            IconoPlay.Visible = false;
            if (rol == "Administrador") Permisos = true;
            this.Show();
            TerminarCarga.Start();
        }

        public void Descanso()
        {
            LabelBienvenida.Text = "";
            LabelNombre.Text = "";
            LabelRol.Text = "Descansando";
            LabelWait.Text = "ZzzZzzZzz...";
            IconoPlay.Visible = true;
        }

        #endregion

        #region Eventos Adicionales

        private bool Permisos = false;
        private string Usuario = "";

        private void TerminarCarga_Tick(object sender, EventArgs e)
        {
            if (Permisos)
            {
                ModuloAdministrador Admin = new ModuloAdministrador();
                Admin.NombreUsuario = Usuario;
                Admin.BotonPerfil.Text = Usuario;
                Admin.Show();
                this.Close();
            }
            else
            {
                ModuloUsuario User = new ModuloUsuario();
                User.Show();
                this.Close();
            }
            TerminarCarga.Stop();
        }

        #endregion

    }
}
