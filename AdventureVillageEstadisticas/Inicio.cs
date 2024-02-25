using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureVillageEstadisticas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            TabControlAll.TabMenuVisible = false;
        }

        #region Funciones fuera del tappages

        #region Botones

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            else MaximizarPanel();
        }
        private void BotonHome_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpHome");
        }
        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpUsuarios");
        }
        private void BotonArticulos_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpArticulos");
        }
        private void BotonOpciones_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpOpciones");
        }
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            Close();
        }

        #endregion

        #region Funciones

        private void MinimizarPanel()
        {
            AnimacionMenu.Start();
            BotonMenu.Text = "";
            BotonHome.Text = "";
            BotonUsuarios.Text = "";
            BotonArticulos.Text = "";
            BotonOpciones.Text = "";
            BotonSalir.Text = "";
        }
        private void MaximizarPanel()
        {
            AnimacionMenu.Start();
        }
        private void MostrarNombres()
        {
            BotonMenu.Text = BotonMenu.Tag.ToString();
            BotonHome.Text = BotonHome.Tag.ToString();
            BotonUsuarios.Text = BotonUsuarios.Tag.ToString();
            BotonArticulos.Text = BotonArticulos.Tag.ToString();
            BotonOpciones.Text = BotonOpciones.Tag.ToString();
            BotonSalir.Text = BotonSalir.Tag.ToString();
        }

        #endregion

        #region Eventos adicionales

        private int MoveX, MoveY;
        private bool MenuExtendido;

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
                    MostrarNombres();
                    MenuExtendido = true;
                    AnimacionMenu.Stop();
                }
            }
        }
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult Cerrar = GunaMessageBox.Show("Seguro deseas salir?", "¡Alerta!");
                if (Cerrar == DialogResult.Yes) Application.Exit();
                else e.Cancel = true;
            }
        }
        private void Inicio_SizeChanged(object sender, EventArgs e)
        {
            PanelBotonesUser.Height = TabControlAll.Height;
            PanelFormUser.Height = TabControlAll.Height;
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

        #endregion

        #endregion

        #region Tappage Home



        #endregion

        #region Tappage Usuario, Crear y Tabla


        #region Seleccionar Opciones

        #region Botones

        private void BotonCrearUsuario_Click(object sender, EventArgs e)
        {
            RellenarComboRol();
            UsuarioTextBox.Text = "";
            ContraseñaTextBox.Text = "";
            ConfirmTextBox.Text = "";
            LabelContraseñasNo.Visible = false;
            TabControlAll.SelectTab("TpCrearUser");
        }

        private void BotonVerUsuarios_Click(object sender, EventArgs e)
        {
            RellenarTablaUsuarios();
            TabControlAll.SelectTab("TpVerUser");
        }

        #endregion

        #region Funciones

        private void RellenarComboRol()
        {
            ComboBoxRoles.Items.Clear();
            ComboBoxRoles.Items.Add("Selecciona Rol");
            ComboBoxRoles.StartIndex = 0;
            Controladores Info = new Controladores();
            List<ModeloRoles> Roles = Info.Roles();
            foreach (var Rol in Roles)
            {
                ComboBoxRoles.Items.Add(Rol._Rol);
            }

        }

        private void RellenarTablaUsuarios()
        {
            DataGridUsuarios.Rows.Clear();
            Controladores Info = new Controladores();
            List<ModeloUsuario> Users = Info.Usuarios();
            foreach (var Usuario in Users)
            {
                if (Usuario._Activo)
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Contraseña,
                        Usuario._Fecha_Registro.ToString(), Usuario._Activo, "Modificar", "Bloquear");
                }
                else
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Contraseña,
                        Usuario._Fecha_Registro.ToString(), Usuario._Activo, "Modificar", "Desbloquear");
                }
            }
        }

        #endregion

        #endregion

        #region Crear Usuarios

        #region Botones

        private void BotonRegresoUser_MouseEnter(object sender, EventArgs e)
        {
            btnregreso = true;
            MoverBotones.Start();
        }
        private void BotonLimpiarUser_MouseEnter(object sender, EventArgs e)
        {
            btnlimpiar = true;
            MoverBotones.Start();
        }
        private void BotonGuardarUser_MouseEnter(object sender, EventArgs e)
        {
            btnguardar = true;
            MoverBotones.Start();
        }
        private void BotonRegresoUser_MouseLeave(object sender, EventArgs e)
        {
            btnregreso = false;
            MoverBotones.Start();
        }
        private void BotonLimpiarUser_MouseLeave(object sender, EventArgs e)
        {
            btnlimpiar = false;
            MoverBotones.Start();
        }
        private void BotonGuardarUser_MouseLeave(object sender, EventArgs e)
        {
            btnguardar = false;
            MoverBotones.Start();
        }
        private void BotonRegresoUser_Click(object sender, EventArgs e)
        {
            TabControlAll.SelectTab("TpUsuarios");
        }
        private void BotonLimpiarUser_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }
        private void BotonGuardarUser_Click(object sender, EventArgs e)
        {
            bool Verficado = true;

            if (ComboBoxRoles.SelectedIndex == 0)
            {
                LabelContraseñasNo.Text = "Seleccione un rol valido";
                LabelContraseñasNo.Visible = true;
                Verficado = false;
            }
            if (UsuarioTextBox.Text.Length < 3)
            {
                LabelContraseñasNo.Text = "Ingrese un usuario con mas de 3 letras";
                LabelContraseñasNo.Visible = true;
                Verficado = false;
            }
            if (ContraseñaTextBox.Text.Length < 8)
            {
                LabelContraseñasNo.Text = "La contraseña es muy debil";
                LabelContraseñasNo.Visible = true;
                Verficado = false;
            }
            if (ContraseñaTextBox.Text != ConfirmTextBox.Text)
            {
                LabelContraseñasNo.Text = "Las contraseñas no coinciden";
                LabelContraseñasNo.Visible = true;
                Verficado = false;
            }

            if (Verficado)
            {
                Controladores Control = new Controladores();
                List<ModeloUsuario> Usuarios = Control.Usuarios();
                ModeloUsuario NewUser = new ModeloUsuario(UsuarioTextBox.Text, ComboBoxRoles.Text, ContraseñaTextBox.Text);
                bool Coincidencia = false;

                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if (NewUser._idUsuario == Usuarios[i]._idUsuario)
                    {
                        Coincidencia = true;
                        NewUser._Fecha_Registro = Usuarios[i]._Fecha_Registro;
                        NewUser._Activo = Usuarios[i]._Activo;
                        DialogResult Confirmar = GunaMessageBox.Show("Este usuario existe ¿Deseas actualizarlo?", "¡Alerta!");
                        if (Confirmar == DialogResult.Yes)
                        {
                            Control.AgregarModificarUsuario(NewUser, false);
                            LimpiarTextos();
                        }
                        break;
                    }
                }
                if (!Coincidencia)
                {
                    Control.AgregarModificarUsuario(NewUser, true);
                    GunaMessageBoxOK.Show("Usuario agregado exitosamente", "¡Exito!");
                    LimpiarTextos();
                }
                LabelContraseñasNo.Visible = false;
            }
        }

        #endregion

        #region Funciones

        private void LimpiarTextos()
        {
            ComboBoxRoles.SelectedIndex = 0;
            UsuarioTextBox.Text = "";
            ContraseñaTextBox.Text = "";
            ConfirmTextBox.Text = "";
        }

        #endregion

        #region Eventos Adicionales

        bool btnregreso, btnlimpiar, btnguardar;

        private void MoverBotones_Tick(object sender, EventArgs e)
        {
            bool cerrar1 = false;
            bool cerrar2 = false;
            bool cerrar3 = false;

            if (btnregreso)
            {
                if (BotonRegresoUser.Location.X > 15) BotonRegresoUser.Location = new Point(BotonRegresoUser.Location.X - 1, BotonRegresoUser.Location.Y);
                cerrar1 = false;
            }
            else
            {
                if (BotonRegresoUser.Location.X < 43) BotonRegresoUser.Location = new Point(BotonRegresoUser.Location.X + 1, BotonRegresoUser.Location.Y);
                else cerrar1 = true;
            }

            if(btnlimpiar)
            {
                if (BotonLimpiarUser.Location.X > 8) BotonLimpiarUser.Location = new Point(BotonLimpiarUser.Location.X - 1, BotonLimpiarUser.Location.Y);
                cerrar2 = false;
            }
            else
            {
                if (BotonLimpiarUser.Location.X < 46) BotonLimpiarUser.Location = new Point(BotonLimpiarUser.Location.X + 1, BotonLimpiarUser.Location.Y);
                else cerrar2 = true;
            }

            if (btnguardar)
            {
                if (BotonGuardarUser.Location.X > 1) BotonGuardarUser.Location = new Point(BotonGuardarUser.Location.X - 1, BotonGuardarUser.Location.Y);
                cerrar3 = false;
            }
            else
            {
                if (BotonGuardarUser.Location.X < 46) BotonGuardarUser.Location = new Point(BotonGuardarUser.Location.X + 1, BotonGuardarUser.Location.Y);
                else cerrar3 = true;
            }

            if (cerrar1 && cerrar2 && cerrar3) MoverBotones.Stop();
        }

        #endregion

        #endregion

        #region Tabla

        #region Eventos Adicionales

        private void DataGridUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Controladores Control = new Controladores();

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Modificar))
            {
                if (e.RowIndex != -1)
                {
                    List<ModeloRoles> Rols = Control.Roles();
                    RellenarComboRol();
                    for(int i = 0; i < Rols.Count; i++)
                    {
                        if(Rols[i]._Rol == DataGridUsuarios.CurrentRow.Cells["idRol"].Value.ToString())
                        {
                            ComboBoxRoles.StartIndex = i+1;
                            break;
                        }
                    }
                    UsuarioTextBox.Text = DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                    ContraseñaTextBox.Text = DataGridUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    TabControlAll.SelectTab("TpCrearUser");
                }
            }

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Bloquear))
            {
                if(e.RowIndex != -1)
                {
                    Control.BloqueoUsuario(DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString(), Convert.ToBoolean(DataGridUsuarios.CurrentRow.Cells["Activo"].Value));
                    RellenarTablaUsuarios();
                }
            }
        }

        #endregion 

        #endregion

        #endregion
    }
}
