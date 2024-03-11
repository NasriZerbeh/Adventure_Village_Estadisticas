using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdventureVillageEstadisticas
{
    public partial class ModuloAdministrador : Form
    {
        public ModuloAdministrador()
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
        private void BotonReportes_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            RellenarGraficoIzq();
            RellenarGraficoDer();
            RellenarTotales();
            TabControlAll.SelectTab("TpReportes");
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
            BotonReportes.Text = "";
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
            BotonReportes.Text = BotonReportes.Tag.ToString();
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
            LimpiarTextos();
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
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloRoles> Roles = Info.Roles();
            foreach (var Rol in Roles)
            {
                ComboBoxRoles.Items.Add(Rol._Rol);
            }

        }

        private void RellenarTablaUsuarios()
        {
            DataGridUsuarios.Rows.Clear();
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloUsuario> Users = Info.Usuarios();
            foreach (var Usuario in Users)
            {
                if (Usuario._Activo)
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Correo,
                        Usuario._Fecha_Registro.ToString(), Usuario._Activo, "Modificar", "Bloquear");
                }
                else
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Correo,
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
            string EmailFormat = "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
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
            if (!Regex.IsMatch(TexBoxCorreoUser.Text, EmailFormat))
            {
                LabelContraseñasNo.Text = "El correo no es valido";
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
                ControladorAdmin Control = new ControladorAdmin();
                List<ModeloUsuario> Usuarios = Control.Usuarios();
                ModeloUsuario NewUser = new ModeloUsuario(UsuarioTextBox.Text, ComboBoxRoles.Text, ContraseñaTextBox.Text, TexBoxCorreoUser.Text);
                bool Coincidencia = false;

                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if (NewUser._idUsuario.ToLower() == Usuarios[i]._idUsuario.ToLower())
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
            }
        }

        #endregion

        #region Funciones

        private void LimpiarTextos()
        {
            ComboBoxRoles.SelectedIndex = 0;
            UsuarioTextBox.Text = "";
            ContraseñaTextBox.Text = "";
            TexBoxCorreoUser.Text = "";
            ConfirmTextBox.Text = "";
            LabelContraseñasNo.Visible = false;
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

            if (btnlimpiar)
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
            ControladorAdmin Control = new ControladorAdmin();

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Modificar))
            {
                if (e.RowIndex != -1)
                {
                    List<ModeloRoles> Rols = Control.Roles();
                    List<ModeloUsuario> Usuario = Control.Usuarios();
                    RellenarComboRol();
                    for (int i = 0; i < Rols.Count; i++)
                    {
                        if (Rols[i]._Rol == DataGridUsuarios.CurrentRow.Cells["idRol"].Value.ToString())
                        {
                            ComboBoxRoles.StartIndex = i + 1;
                            break;
                        }
                    }
                    foreach (var User in Usuario)
                    {
                        if (User._idUsuario.ToLower() == DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString().ToLower())
                        {
                            UsuarioTextBox.Text = User._idUsuario;
                            TexBoxCorreoUser.Text = User._Correo;
                            ContraseñaTextBox.Text = User._Contraseña;
                            ConfirmTextBox.Text = User._Contraseña;
                        }
                    }
                    TabControlAll.SelectTab("TpCrearUser");
                }
            }

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Bloquear))
            {
                if (e.RowIndex != -1)
                {
                    Control.BloqueoUsuario(DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString(), Convert.ToBoolean(DataGridUsuarios.CurrentRow.Cells["Activo"].Value));
                    RellenarTablaUsuarios();
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region Articulos, Crear y Tabla

        #region Seleccionar Opciones

        #region Botones

        private void BotonCrearArticulo_Click(object sender, EventArgs e)
        {
            RellenarCombosBoxesArticulos();
            LimpiarTextosArticulos();
            TabControlAll.SelectTab("TpCrearArticulos");
        }

        private void BotonVerArticulos_Click(object sender, EventArgs e)
        {
            RellenarTablaArticulos();
            TabControlAll.SelectTab("TpVerArticulos");
        }

        #endregion

        #region Funciones

        private void RellenarCombosBoxesArticulos()
        {
            ControladorAdmin Info = new ControladorAdmin();

            ComboBoxTipoArticulo.Items.Clear();
            ComboBoxTipoArticulo.Items.Add("Selecciona un tipo.");
            ComboBoxTipoArticulo.StartIndex = 0;
            List<ModeloTipoArticulo> T_Articulo = Info.TiposArticulo();
            foreach (var Tipo in T_Articulo)
            {
                ComboBoxTipoArticulo.Items.Add(Tipo._Nombre_Tipo);
            }

            ComboBoxStat.Items.Clear();
            ComboBoxStat.Items.Add("");
            ComboBoxStat.StartIndex = 0;
            List<ModeloTipoStats> T_Stats = Info.TipoStats();
            foreach (var Tipo in T_Stats)
            {
                ComboBoxStat.Items.Add(Tipo._Nombre_TipoS);
            }

            ComboBoxPTS.Items.Clear();
            ComboBoxPTS.Items.Add("");
            ComboBoxPTS.StartIndex = 0;
            List<ModeloModoStats> M_Stats = Info.ModoStats();
            foreach (var Modo in M_Stats)
            {
                ComboBoxPTS.Items.Add(Modo._Modo_Stats);
            }

        }

        private void RellenarTablaArticulos()
        {
            DataGridArticulos.Rows.Clear();
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloArticulos> Articulo = Info.Articulos();
            foreach (var Articulos in Articulo)
            {
                if (Articulos._Activo)
                {
                    DataGridArticulos.Rows.Add(Articulos._idArticulo, Articulos._NombreArticulo, Articulos._Tipo,
                        Articulos._Nombre_Stat + ": + " + Articulos._Cantidad_Stats.ToString() + Articulos._Modo_Stats, Articulos._Activo, "Modificar", "Ocultar");
                }
                else
                {
                    DataGridArticulos.Rows.Add(Articulos._idArticulo, Articulos._NombreArticulo, Articulos._Tipo,
                        Articulos._Nombre_Stat + ": + " + Articulos._Cantidad_Stats.ToString() + Articulos._Modo_Stats, Articulos._Activo, "Modificar", "Mostrar");
                }
            }
        }


        #endregion

        #endregion

        #region Crear Articulos

        #region Botones

        private void BotonSalirArticulo_MouseEnter(object sender, EventArgs e)
        {
            btnregresoArticulo = true;
            MoverBotonesArticulos.Start();
        }

        private void BotonLimpiarArticulo_MouseEnter(object sender, EventArgs e)
        {
            btnlimpiarArticulo = true;
            MoverBotonesArticulos.Start();
        }

        private void BotonGuardarArticulo_MouseEnter(object sender, EventArgs e)
        {
            btnguardarArticulo = true;
            MoverBotonesArticulos.Start();
        }

        private void BotonSalirArticulo_MouseLeave(object sender, EventArgs e)
        {
            btnregresoArticulo = false;
            MoverBotonesArticulos.Start();
        }

        private void BotonLimpiarArticulo_MouseLeave(object sender, EventArgs e)
        {
            btnlimpiarArticulo = false;
            MoverBotonesArticulos.Start();
        }

        private void BotonGuardarArticulo_MouseLeave(object sender, EventArgs e)
        {
            btnguardarArticulo = false;
            MoverBotonesArticulos.Start();
        }

        private void BotonSalirArticulo_Click(object sender, EventArgs e)
        {
            TabControlAll.SelectTab("TpArticulos");
        }

        private void BotonLimpiarArticulo_Click(object sender, EventArgs e)
        {
            LimpiarTextosArticulos();
        }

        string URLArticulo;

        private void BotonGuardarArticulo_Click(object sender, EventArgs e)
        {
            string Error = "";
            bool Validado = true;

            if (IDArticuloTextBox.Text == "") { Error = "Falta ID de Articulo"; Validado = false; }
            if (NombreArticuloTextBox.Text == "") { Error = "Falta Nombre de Articulo"; Validado = false; }
            if (URLArticulo == "") { Error = "Falta la imagen del Articulo"; Validado = false; }
            if (ComboBoxTipoArticulo.SelectedIndex == 0) { Error = "Seleccione un Tipo de Articulo"; Validado = false; }
            if (ComboBoxStat.SelectedIndex == 0) { Error = "Seleccione una Estadistica"; Validado = false; }
            if (StatArticulo.Value > 100 && ComboBoxPTS.SelectedIndex == 1) { Error = "El porcentaje no puede ser mayor a 100"; Validado = false; }
            if (ComboBoxPTS.SelectedIndex == 0) { Error = "Seleccione un modo de punto"; Validado = false; }
            if (Validado)
            {
                ControladorAdmin Control = new ControladorAdmin();
                List<ModeloArticulos> Articulos = Control.Articulos();
                string Guardar = GuardarImagen("Articulos", IDArticuloTextBox.Text);
                ModeloArticulos NewArticulo = new ModeloArticulos(IDArticuloTextBox.Text, NombreArticuloTextBox.Text, Guardar, ComboBoxTipoArticulo.Text, ComboBoxStat.Text, Convert.ToInt32(StatArticulo.Value), ComboBoxPTS.Text);
                bool Coincidencia = false;

                for (int i = 0; i < Articulos.Count; i++)
                {
                    if (NewArticulo._idArticulo.ToLower() == Articulos[i]._idArticulo.ToLower())
                    {
                        Coincidencia = true;
                        NewArticulo._Activo = Articulos[i]._Activo;
                        DialogResult Confirmar = GunaMessageBox.Show("Este Articulo existe ¿Deseas actualizarlo?", "¡Alerta!");
                        if (Confirmar == DialogResult.Yes)
                        {
                            Control.AgregarModificarArticulo(NewArticulo, false);
                            LimpiarTextosArticulos();
                        }
                        break;
                    }
                }
                if (!Coincidencia)
                {
                    Control.AgregarModificarArticulo(NewArticulo, true);
                    GunaMessageBoxOK.Show("Articulo agregado exitosamente", "¡Exito!");
                    LimpiarTextosArticulos();
                }
                CopiarImagenLocal(URLArticulo, Guardar);
            }
            else
            {
                LabelErrorArticulo.Text = Error;
                LabelErrorArticulo.Visible = true;
            }
        }

        private void BotonBuscarArticulo_Click(object sender, EventArgs e)
        {
            OpenFileArticulos.ShowDialog();
            if (File.Exists(OpenFileArticulos.FileName))
            {
                URLArticulo = OpenFileArticulos.FileName;
                ImagenArticulo.ImageLocation = OpenFileArticulos.FileName;
            }
        }

        #endregion

        #region Funciones

        private void LimpiarTextosArticulos()
        {
            ImagenArticulo.ImageLocation = "";
            IDArticuloTextBox.Text = "";
            NombreArticuloTextBox.Text = "";
            ComboBoxTipoArticulo.SelectedIndex = 0;
            ComboBoxStat.SelectedIndex = 0;
            StatArticulo.Value = 1;
            ComboBoxPTS.SelectedIndex = 0;
            LabelErrorArticulo.Visible = false;
        }

        private string GuardarImagen(string carpeta, string archivo)
        {
            string DestinoURLArticulo = Path.GetFullPath(@"..\..\ImagenesOpenFile\" + carpeta + "\\");
            string DireccionCompletaPNGArticulo = Path.Combine(DestinoURLArticulo, archivo + ".png");

            return DireccionCompletaPNGArticulo;
        }

        private void CopiarImagenLocal(string URLCopy, string DireccionCompletaPNGArticulo)
        {
            try
            {
                File.Copy(URLCopy, DireccionCompletaPNGArticulo, true);
            }
            catch { }
            URLArticulo = "";
        }

        #endregion

        #region Eventos Adicionales

        bool btnregresoArticulo, btnlimpiarArticulo, btnguardarArticulo;

        private void DatePickGrafDeIzq_ValueChanged(object sender, EventArgs e)
        {
            RellenarGraficoIzq();

        }

        private void DatePickGrafHastaIzq_ValueChanged(object sender, EventArgs e)
        {
            RellenarGraficoIzq();
        }

        private void ComboBoxRangoIzq_SelectedValueChanged(object sender, EventArgs e)
        {
            RellenarGraficoIzq();
        }

        private void MoverBotonesArticulos_Tick(object sender, EventArgs e)
        {
            bool cerrar1 = false;
            bool cerrar2 = false;
            bool cerrar3 = false;

            if (btnregresoArticulo)
            {
                if (BotonSalirArticulo.Location.X > 38) BotonSalirArticulo.Location = new Point(BotonSalirArticulo.Location.X - 1, BotonSalirArticulo.Location.Y);
                cerrar1 = false;
            }
            else
            {
                if (BotonSalirArticulo.Location.X < 68) BotonSalirArticulo.Location = new Point(BotonSalirArticulo.Location.X + 1, BotonSalirArticulo.Location.Y);
                else cerrar1 = true;
            }

            if (btnlimpiarArticulo)
            {
                if (BotonLimpiarArticulo.Location.X > 30) BotonLimpiarArticulo.Location = new Point(BotonLimpiarArticulo.Location.X - 1, BotonLimpiarArticulo.Location.Y);
                cerrar2 = false;
            }
            else
            {
                if (BotonLimpiarArticulo.Location.X < 70) BotonLimpiarArticulo.Location = new Point(BotonLimpiarArticulo.Location.X + 1, BotonLimpiarArticulo.Location.Y);
                else cerrar2 = true;
            }

            if (btnguardarArticulo)
            {
                if (BotonGuardarArticulo.Location.X > 24) BotonGuardarArticulo.Location = new Point(BotonGuardarArticulo.Location.X - 1, BotonGuardarArticulo.Location.Y);
                cerrar3 = false;
            }
            else
            {
                if (BotonGuardarArticulo.Location.X < 70) BotonGuardarArticulo.Location = new Point(BotonGuardarArticulo.Location.X + 1, BotonGuardarArticulo.Location.Y);
                else cerrar3 = true;
            }

            if (cerrar1 && cerrar2 && cerrar3) MoverBotonesArticulos.Stop();
        }

        private void ComboBoxOpcionDer_SelectedValueChanged(object sender, EventArgs e)
        {
            RellenarGraficoDer();
        }

        #endregion

        #endregion

        #region Tabla Articulos

        private void DataGridArticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ControladorAdmin Control = new ControladorAdmin();
            List<ModeloArticulos> Articulos = Control.Articulos();

            if (e.ColumnIndex == DataGridArticulos.Columns.IndexOf(ModificarArticulos))
            {
                if (e.RowIndex != -1)
                {
                    RellenarCombosBoxesArticulos();
                    foreach (var Articulo in Articulos)
                    {
                        if (Articulo._idArticulo == DataGridArticulos.CurrentRow.Cells["IDArticulo"].Value.ToString())
                        {
                            IDArticuloTextBox.Text = Articulo._idArticulo;
                            NombreArticuloTextBox.Text = Articulo._NombreArticulo;
                            ImagenArticulo.ImageLocation = Articulo._URLImagen;
                            URLArticulo = Articulo._URLImagen;
                            for (int i = 0; i < ComboBoxTipoArticulo.Items.Count; i++)
                            {
                                if (Articulo._Tipo == ComboBoxTipoArticulo.Items[i].ToString())
                                {
                                    ComboBoxTipoArticulo.StartIndex = i;
                                }
                            }
                            for (int i = 0; i < ComboBoxStat.Items.Count; i++)
                            {
                                if (Articulo._Nombre_Stat == ComboBoxStat.Items[i].ToString())
                                {
                                    ComboBoxStat.StartIndex = i;
                                }
                            }
                            StatArticulo.Value = Articulo._Cantidad_Stats;
                            for (int i = 0; i < ComboBoxPTS.Items.Count; i++)
                            {
                                if (Articulo._Modo_Stats == ComboBoxPTS.Items[i].ToString())
                                {
                                    ComboBoxPTS.StartIndex = i;
                                }
                            }
                        }
                    }
                    TabControlAll.SelectTab("TpCrearArticulos");

                }
            }

            if (e.ColumnIndex == DataGridArticulos.Columns.IndexOf(MostrarArticulos))
            {
                if (e.RowIndex != -1)
                {
                    Control.OcultarArticulo(DataGridArticulos.CurrentRow.Cells["IDArticulo"].Value.ToString(), Convert.ToBoolean(DataGridArticulos.CurrentRow.Cells["ActivoArticulo"].Value));
                    RellenarTablaArticulos();
                }
            }
        }

        int r = 120, g = 120, b = 120;
        bool reversa = false;
        private void CambiarColor_Tick(object sender, EventArgs e)
        {
            if(!reversa)
            {
                LabelTotalUsuariosTittle.ForeColor = Color.FromArgb(r, g, b);
                LabelTotalArticulosTittle.ForeColor = Color.FromArgb(r, g, b);
                LabelCantTotalUsuarios.ForeColor = Color.FromArgb(r, g, b);
                LabelCantTotalArticulos.ForeColor = Color.FromArgb(r, g, b);
                r += 10; g += 30; b += 10;
                if (g >= 240) reversa = true;
            }
            else
            {
                LabelTotalUsuariosTittle.ForeColor = Color.FromArgb(r, g, b);
                LabelTotalArticulosTittle.ForeColor = Color.FromArgb(r, g, b);
                LabelCantTotalUsuarios.ForeColor = Color.FromArgb(r, g, b);
                LabelCantTotalArticulos.ForeColor = Color.FromArgb(r, g, b);
                r -= 10; g -= 30; b -= 10;
                if (g <= 120) reversa = false;
            }
        }

        #endregion

        #endregion

        #region Reportes

        #region Botones

        private void BotonGenerarReporteA_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "ReporteUsuario_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            Guardar.Filter = "Archivo PDF|.pdf";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Controladores.Reportes Reporte = new Controladores.Reportes();
                ControladorAdmin Info = new ControladorAdmin();
                Reporte.ReporteUsuarios(Guardar.FileName, Info.Usuarios());
                GunaMessageBoxOK.Show("Reporte exportado exitosamente.", "Información.");
            }
        }

        #endregion

        #region Funciones

        private void RellenarGraficoIzq()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<Modelos.ModeloRangoCantidad> RangoCantidad = new List<Modelos.ModeloRangoCantidad>();
            ArrayList Rangos = new ArrayList();
            ArrayList Cantidad = new ArrayList();

            RangoCantidad = Info.RangoUsuariosGraficoIzq(DatePickGrafDeIzq.Value.ToString("yyyy-MM-dd"), DatePickGrafHastaIzq.Value.ToString("yyyy-MM-dd"), ComboBoxRangoIzq.SelectedIndex);
            foreach (var Rang in RangoCantidad)
            {
                Rangos.Add(Rang._Rango);
                Cantidad.Add(Rang._Cantidad);
            }
            ChartIzq.Series[0].Points.DataBindXY(Rangos, Cantidad);
        }

        private void RellenarGraficoDer()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<Modelos.ModeloRangoCantidad> RangoCantidad = new List<Modelos.ModeloRangoCantidad>();
            ArrayList Rangos = new ArrayList();
            ArrayList Cantidad = new ArrayList();

            RangoCantidad = Info.RangoArticulosGraficoDer(ComboBoxOpcionDer.SelectedIndex);
            foreach (var Rang in RangoCantidad)
            {
                Rangos.Add(Rang._Rango);
                Cantidad.Add(Rang._Cantidad);
            }
            ChartDer.Series[0].Points.DataBindXY(Rangos, Cantidad);
        }

        private void RellenarTotales()
        {
            ControladorAdmin Info = new ControladorAdmin();
            LabelCantTotalUsuarios.Text = Info.CantidadTotalDe(1).ToString();
            LabelCantTotalArticulos.Text = Info.CantidadTotalDe(2).ToString();
        }

        

        #endregion

        #endregion

        #region Opciones

        private void SwitchDescanso_Click(object sender, EventArgs e)
        {
            InterfazCarga Descanso = new InterfazCarga();
            Descanso.Descanso();
            this.Hide();
            SwitchDescanso.Checked = false;
            Descanso.ShowDialog();
            this.Show();
        }

        #endregion
    }
}
