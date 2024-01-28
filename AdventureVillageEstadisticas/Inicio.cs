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
    public partial class Inicio : Form
    {
        private int MoveX, MoveY;
        private bool MenuExtendido;
        private ConexionBD Conectar;
        public Inicio()
        {
            InitializeComponent();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            else MaximizarPanel();
        }
        private void BotonHome_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
        }
        private void BotonOpciones_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            Close();
        }
        private void MinimizarPanel()
        {
            AnimacionMenu.Start();
            BotonMenu.Text = "";
            BotonHome.Text = "";
            BotonOpciones.Text = "";
            BotonSalir.Text = "";
        }

        private void MaximizarPanel()
        {
            AnimacionMenu.Start();
            BotonMenu.Text = BotonMenu.Tag.ToString();
            BotonHome.Text = BotonHome.Tag.ToString();
            BotonOpciones.Text = BotonOpciones.Tag.ToString();
            BotonSalir.Text = BotonSalir.Tag.ToString();
        }

        private void AnimacionTiempo_Tick(object sender, EventArgs e)
        {
            if (MenuExtendido)
            {
                PanelMenu.Width -= 10;
                if (PanelMenu.Width == PanelMenu.MinimumSize.Width)
                {
                    MenuExtendido = false;
                    AnimacionMenu.Stop();
                }
            }
            else
            {
                PanelMenu.Width += 10;
                if (PanelMenu.Width == PanelMenu.MaximumSize.Width)
                {
                    MenuExtendido = true;
                    AnimacionMenu.Stop();
                }
            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult Cerrar = MessageBox.Show("Seguro deseas salir?", "Alert", MessageBoxButtons.YesNo);
                if (Cerrar == DialogResult.Yes) Application.Exit();
                else e.Cancel = true;
            }
        }

        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MoveX = e.X;
                MoveY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MoveX);
                Top = Top + (e.Y - MoveY);
            }
        }
    }
}
