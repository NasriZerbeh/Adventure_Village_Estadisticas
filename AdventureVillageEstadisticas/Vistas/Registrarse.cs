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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        #region Botones



        #endregion

        #region Funciones

        private void VerificarCampos()
        {
            bool Validado = true;
            LimpiarErrores();
            Reportes_y_Validaciones.Validaciones Validar = new Reportes_y_Validaciones.Validaciones();
            if (!Validar.NoCamposVacios(UsuarioTextBoxRegistrarse.Text) || !Validar.RangoCaracteres(UsuarioTextBoxRegistrarse.Text, 3, 20) || !Validar.StringNumber(UsuarioTextBoxRegistrarse.Text))
            {
                Validado = false;
                ErrorImagenUsuario.Visible = true;
            }
            if (!Validar.CorreoEmail(CorreoTextBoxRegistrarse.Text))
            {
                Validado = false;
                ErrorImagenCorreo.Visible = true;
            }
            if (!Validar.Contraseña(ContraseñaTextBoxRegistrarse.Text))
            {
                Validado = false;
                ErrorImagenContraseña.Visible = true;
            }
            if (!Validar.ConfirmarContraseñas(ContraseñaTextBoxRegistrarse.Text, ConfirmarTextBoxRegistrarse.Text))
            {
                Validado = false;
                ErrorImagenConfirmar.Visible = true;
            }

            if (Validado)
            {
                ModeloUsuario Usuario = new ModeloUsuario(UsuarioTextBoxRegistrarse.Text, "ROL_USER", ContraseñaTextBoxRegistrarse.Text, CorreoTextBoxRegistrarse.Text);
                Controladores.ControladorRegistro Registro = new Controladores.ControladorRegistro();
                if(Registro.ConfirmarRegistro(Usuario))
                {
                    GunaMessageBoxLogin.Show("Registrado Exitosamente.", "Información");
                    this.Close();
                }
                else
                {
                    GunaMessageBoxLogin.Show("El Usuario ya existe.", "Información");
                    ErrorImagenUsuario.Visible = true;
                }
            }

        }

        #endregion

        #region Eventos adicionales

        private int MoveX, MoveY;

        private void LabelIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void LimpiarErrores()
        {
            ErrorImagenUsuario.Visible = false;
            ErrorImagenCorreo.Visible = false;
            ErrorImagenContraseña.Visible = false;
            ErrorImagenConfirmar.Visible = false;
        }

        private void PanelControlRegistrarse_MouseMove(object sender, MouseEventArgs e)
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

        #endregion

    }
}
