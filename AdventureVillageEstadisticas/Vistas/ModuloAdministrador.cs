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
        public string NombreUsuario = ""; 
        public ModuloAdministrador()
        {
            InitializeComponent();
            IniciarApp();
        }

        #region Formulario

        #region Funciones del Formulario

        private void IniciarApp() 
        {
            QuitarBordes();
            QuitarNombres();
            BotonMenu.BorderThickness = 3;
            BotonHome.BorderThickness = 3;
            PanelMenu.Height = 530;
            TabControlAll.TabMenuVisible = false;
            DatePickFiltroHastaUsuarios.Value = DateTime.Now;
            DatePickFiltroHastaRegistro.Value = DateTime.Now;
            DatePickGrafHastaIzq.Value = DateTime.Now;
        }

        #endregion

        #region Eventos del Formulario

        private int MoveX, MoveY;

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
        private void ModuloAdministrador_SizeChanged(object sender, EventArgs e)
        {
            PanelBotonesUser.Height = TabControlAll.Height;
            PanelFormUser.Height = TabControlAll.Height;
            PanelOpcionesArticulos.Height = TabControlAll.Height;
            PanelAjusteArticulos.Height = TabControlAll.Height;
            PanelMenu.Height = this.Height - 30;
            SeparadorMenuTab.Height = this.Height - 30;
        }
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult Cerrar = GunaMessageBox.Show("Seguro deseas salir?", "¡Alerta!");
                if (Cerrar == DialogResult.Yes)
                {
                    Login Regresar = new Login();
                    Regresar.Show();
                }
                else e.Cancel = true;
            }
        }

        #endregion

        #endregion

        #region Menu

        #region Botones del Menu

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) { MinimizarPanel(); BotonMenu.BorderThickness = 0; }
            else { MaximizarPanel(); BotonMenu.BorderThickness = 3; }
        }
        private void BotonHome_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonHome.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpHome");
        }
        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonUsuarios.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpUsuarios");
        }
        private void BotonArticulos_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonArticulos.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpArticulos");
        }
        private void BotonReportes_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonReportes.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            RellenarGraficoIzq();
            RellenarGraficoDer();
            RellenarSegundoGrafIzq();
            RellenarGraficosEstaticos();
            RellenarTotales();
            TabControlAll.SelectTab("TpReportes");
        }
        private void BotonAggDatos_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonAggDatos.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            RellenarItemsDatos();
            DatosxDefecto();
            TabControlAll.SelectTab("TpAggNuevo");
        }
        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonRegistro.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            ControladorAdmin Info = new ControladorAdmin();
            RellenarRegistros(Info.FiltroRegistros(TextBoxFiltroIDRegistro.Text, TextBoxFiltroUsuarioRegistro.Text, DatePickFiltroDesdeRegistro.Value.ToString("yyyy-MM-dd"), DatePickFiltroHastaRegistro.Value.ToString("yyyy-MM-dd"), ComboBoxFiltroMovimientos.SelectedIndex, ComboBoxFiltroOrdenRegistro.Text));
            TabControlAll.SelectTab("TpRegistroActividad");
        }
        private void BotonOpciones_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonOpciones.BorderThickness = 3;
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpOpciones");
        }
        private void BotonPerfil_Click(object sender, EventArgs e)
        {
            QuitarBordes();
            BotonPerfil.BorderThickness = 3;
            ControladorAdmin Perfil = new ControladorAdmin();
            RellenarPerfil(Perfil.MostrarPerfil(NombreUsuario));
            if (MenuExtendido) MinimizarPanel();
            TabControlAll.SelectTab("TpPerfil");
        }
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            if (MenuExtendido) MinimizarPanel();
            Close();
        }

        #endregion

        #region Funciones del Menu

        private void MinimizarPanel()
        {
            QuitarNombres();
            AnimacionMenu.Start();
        }
        private void MaximizarPanel()
        {
            AnimacionMenu.Start();
        }
        private void QuitarBordes()
        {
            BotonMenu.BorderThickness = 0;
            BotonHome.BorderThickness = 0;
            BotonUsuarios.BorderThickness = 0;
            BotonArticulos.BorderThickness = 0;
            BotonReportes.BorderThickness = 0;
            BotonAggDatos.BorderThickness = 0;
            BotonRegistro.BorderThickness = 0;
            BotonOpciones.BorderThickness = 0;
            BotonPerfil.BorderThickness = 0;
            BotonSalir.BorderThickness = 0;
        }
        private void QuitarNombres()
        {
            BotonMenu.Text = "";
            BotonHome.Text = "";
            BotonUsuarios.Text = "";
            BotonArticulos.Text = "";
            BotonReportes.Text = "";
            BotonAggDatos.Text = "";
            BotonRegistro.Text = "";
            BotonOpciones.Text = "";
            BotonPerfil.Text = "";
            BotonSalir.Text = "";
        }
        private void MostrarNombres()
        {
            BotonMenu.Text = BotonMenu.Tag.ToString();
            BotonHome.Text = BotonHome.Tag.ToString();
            BotonUsuarios.Text = BotonUsuarios.Tag.ToString();
            BotonArticulos.Text = BotonArticulos.Tag.ToString();
            BotonReportes.Text = BotonReportes.Tag.ToString();
            BotonAggDatos.Text = BotonAggDatos.Tag.ToString();
            BotonRegistro.Text = BotonRegistro.Tag.ToString();
            BotonOpciones.Text = BotonOpciones.Tag.ToString();
            BotonPerfil.Text = NombreUsuario;
            BotonSalir.Text = BotonSalir.Tag.ToString();
        }

        #endregion

        #region Eventos del Menu

        private bool MenuExtendido;

        private void AnimacionTiempo_Tick(object sender, EventArgs e)
        {
            if (MenuExtendido)
            {
                PanelMenu.Width -= 15;
                SeparadorMenuTab.Location = new Point(PanelMenu.Width, SeparadorMenuTab.Location.Y);
                if (PanelMenu.Width <= PanelMenu.MinimumSize.Width)
                {
                    MenuExtendido = false;
                    AnimacionMenu.Stop();
                }
            }
            else
            {
                PanelMenu.Width += 15;
                SeparadorMenuTab.Location = new Point(PanelMenu.Width, SeparadorMenuTab.Location.Y);
                if (PanelMenu.Width >= PanelMenu.MaximumSize.Width)
                {
                    MostrarNombres();
                    MenuExtendido = true;
                    AnimacionMenu.Stop();
                }
            }
        }

        #endregion

        #endregion

        #region Home

        #endregion

        #region Usuarios

        #region Botones Usuario

        private void BotonCrearUsuario_Click(object sender, EventArgs e)
        {
            RellenarComboRol();
            LimpiarTextos();
            LabelCrearUsuario.Text = "Crear Usuario";
            TabControlAll.SelectTab("TpCrearUser");
        }

        private void BotonVerUsuarios_Click(object sender, EventArgs e)
        {
            RellenarComboRolFiltro();
            BuscarFiltro();
            TabControlAll.SelectTab("TpVerUser");
        }
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
            VerificarYCrearUsuario();
        }
        private void BotonGenerarReporteA_Click(object sender, EventArgs e)
        {
            ControladorAdmin Info = new ControladorAdmin();
            GenerarReporteUsuarios(Info.FiltroUsuarios(TexBoxFiltroUsuario.Text, ComboBoxFiltroRol.Text, TexBoxFiltroCorreo.Text, DatePickFiltroDesdeUsuario.Value.ToString("yyyy-MM-dd"), DatePickFiltroHastaUsuarios.Value.ToString("yyyy-MM-dd"), ComboBoxFiltroActivo.SelectedIndex, ComboBoxOrdenarUsuarios.Text), ComboBoxOrdenarUsuarios.Text);
        }

        private void BotonFiltroLimpiarUser_Click(object sender, EventArgs e)
        {
            LimpiarFiltroUser();
        }

        private void BotonFiltroBuscar_Click(object sender, EventArgs e)
        {
            BuscarFiltro();
        }

        #endregion

        #region Funciones Usuario

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
        private void RellenarComboRolFiltro()
        {
            ComboBoxFiltroRol.Items.Clear();
            ComboBoxFiltroRol.Items.Add("Todos");
            ComboBoxFiltroRol.StartIndex = 0;
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloRoles> Roles = Info.Roles();
            foreach (var Rol in Roles)
            {
                ComboBoxFiltroRol.Items.Add(Rol._Rol);
            }
        }
        private void RellenarTablaUsuarios(List<ModeloUsuario> Users)
        {
            DataGridUsuarios.Rows.Clear();
            foreach (var Usuario in Users)
            {
                if (Usuario._Activo)
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Correo,
                        Usuario._Fecha_Registro.ToString(), Usuario._Activo, "Modificar", "Bloquear", "Ver Perfil");
                }
                else
                {
                    DataGridUsuarios.Rows.Add(Usuario._idUsuario, Usuario._idRol, Usuario._Correo,
                        Usuario._Fecha_Registro.ToString(), Usuario._Activo, "Modificar", "Desbloquear", "Ver Perfil");
                }
            }
        }
        private void QuitarErroresUsuario()
        {
            ErrorRol.Visible = false;
            ErrorUsuario.Visible = false;
            ErrorCorreo.Visible = false;
            ErrorContraseña.Visible = false;
            ErrorConfirmacion.Visible = false;
        }
        private void LimpiarTextos()
        {
            ComboBoxRoles.SelectedIndex = 0;
            UsuarioTextBox.Text = "";
            ContraseñaTextBox.Text = "";
            TexBoxCorreoUser.Text = "";
            ConfirmTextBox.Text = "";
            LabelContraseñasNo.Visible = false;
        }
        private void VerificarYCrearUsuario()
        {
            Reportes_y_Validaciones.Validaciones Validar = new Reportes_y_Validaciones.Validaciones();
            QuitarErroresUsuario();
            bool Validado = true;
            if (ComboBoxRoles.SelectedIndex == 0)
            {
                Validado = false;
                ErrorRol.Visible = true;
            }
            if (!Validar.NoCamposVacios(UsuarioTextBox.Text) || !Validar.RangoCaracteres(UsuarioTextBox.Text, 3, 20) || !Validar.StringNumber(UsuarioTextBox.Text))
            {
                Validado = false;
                ErrorUsuario.Visible = true;
            }
            if (!Validar.CorreoEmail(TexBoxCorreoUser.Text))
            {
                Validado = false;
                ErrorCorreo.Visible = true;
            }
            if (!Validar.Contraseña(ContraseñaTextBox.Text))
            {
                Validado = false;
                ErrorContraseña.Visible = true;
            }
            if (!Validar.ConfirmarContraseñas(ContraseñaTextBox.Text, ConfirmTextBox.Text))
            {
                Validado = false;
                ErrorConfirmacion.Visible = true;
            }

            if (Validado)
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
                            Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Modificado al usuario " + NewUser._idUsuario);
                            Control.AñadirBitacora(Bitacora);
                            LimpiarTextos();
                        }
                        break;
                    }
                }
                if (!Coincidencia)
                {
                    Control.AgregarModificarUsuario(NewUser, true);
                    Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Agregado al usuario " + NewUser._idUsuario);
                    Control.AñadirBitacora(Bitacora);
                    GunaMessageBoxOK.Show("Usuario agregado exitosamente", "¡Exito!");
                    LimpiarTextos();
                }
            }
        }
        private void LimpiarFiltroUser()
        {
            TexBoxFiltroUsuario.Text = "";
            ComboBoxFiltroRol.SelectedIndex = 0;
            TexBoxFiltroCorreo.Text = "";
            DatePickFiltroDesdeUsuario.Value = new DateTime(2024, 01, 01);
            DatePickFiltroHastaUsuarios.Value = DateTime.Now;
            ComboBoxFiltroActivo.SelectedIndex = 0;
            ComboBoxOrdenarUsuarios.SelectedIndex = 0;
        }
        private void BuscarFiltro()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloUsuario> Filtro = Info.FiltroUsuarios(TexBoxFiltroUsuario.Text, ComboBoxFiltroRol.Text, TexBoxFiltroCorreo.Text, DatePickFiltroDesdeUsuario.Value.ToString("yyyy-MM-dd"), DatePickFiltroHastaUsuarios.Value.ToString("yyyy-MM-dd"), ComboBoxFiltroActivo.SelectedIndex, ComboBoxOrdenarUsuarios.Text);
            RellenarTablaUsuarios(Filtro);
        }
        private void GenerarReporteUsuarios(List<ModeloUsuario> ListaUsuario, string Filtro)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "ReporteUsuario_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            Guardar.Filter = "Documento PDF|*.pdf";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Controladores.Reportes Reporte = new Controladores.Reportes();
                Reporte.ReporteUsuarios(Guardar.FileName, ListaUsuario, Filtro);
                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Exportado el registro de Usuarios");
                ControladorAdmin GuardarInfo = new ControladorAdmin();
                GuardarInfo.AñadirBitacora(Bitacora);
                GunaMessageBoxOK.Show("Reporte exportado exitosamente.", "Información.");
            }
        }

        #endregion

        #region Eventos Usuario

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

        #region Tabla Usuario

        private void DataGridUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ControladorAdmin Control = new ControladorAdmin();
            List<ModeloUsuario> Usuario = Control.Usuarios();

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Modificar))
            {
                if (e.RowIndex != -1)
                {
                    List<ModeloRoles> Rols = Control.Roles();
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
                    LabelCrearUsuario.Text = "Modificar Usuario";
                    TabControlAll.SelectTab("TpCrearUser");
                }
            }

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(Bloquear))
            {
                if (e.RowIndex != -1)
                {
                    Control.BloqueoUsuario(DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString(), Convert.ToBoolean(DataGridUsuarios.CurrentRow.Cells["Activo"].Value));
                    RellenarTablaUsuarios(Usuario);
                }
            }

            if (e.ColumnIndex == DataGridUsuarios.Columns.IndexOf(VerPerfil))
            {
                if (e.RowIndex != -1)
                {
                    RellenarPerfil(Control.MostrarPerfil(DataGridUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString()));
                    TabControlAll.SelectTab("TpPerfil");
                }
            }
        }

        #endregion 

        #endregion

        #region Articulos

        #region Botones Articulos

        private void BotonCrearArticulo_Click(object sender, EventArgs e)
        {
            RellenarCombosBoxesArticulos();
            LimpiarTextosArticulos();
            LabelCrearArticulo.Text = "Crear Articulo";
            TabControlAll.SelectTab("TpCrearArticulos");
        }

        private void BotonVerArticulos_Click(object sender, EventArgs e)
        {
            RellenarCombosBoxesFiltrosArticulos();
            BuscarFiltroArticulos();
            TabControlAll.SelectTab("TpVerArticulos");
        }
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
        private void BotonGuardarArticulo_Click(object sender, EventArgs e)
        {
            GuardarArticulo();
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

        private void BotonFiltroLimpiarArticulos_Click(object sender, EventArgs e)
        {
            LimpiarFiltrosArticulos();
        }

        private void BotonFiltroBuscarArticulos_Click(object sender, EventArgs e)
        {
            BuscarFiltroArticulos();
        }

        private void BotonGenerarReporteArticulos_Click(object sender, EventArgs e)
        {
            ControladorAdmin Info = new ControladorAdmin();
            GenerarReporteArticulos(Info.FiltroArticulos(TextBoxFiltroIDArticulo.Text, TextBoxFiltroNombreArticulo.Text, ComboBoxFiltroTipoArt.Text, ComboBoxFiltroTipoStats.Text, Convert.ToInt32(NumericFiltroDEArticulo.Value), Convert.ToInt32(NumericFiltroHastaArticulo.Value), ComboBoxFiltroModoStatsArt.Text, ComboBoxFiltroActivoArticulo.SelectedIndex, ComboBoxFiltroOrdenArticulos.SelectedIndex), ComboBoxFiltroOrdenArticulos.Text);
        }


        #endregion

        #region Funciones Articulos

        string URLArticulo;

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
        private void RellenarCombosBoxesFiltrosArticulos()
        {
            ControladorAdmin Info = new ControladorAdmin();

            ComboBoxFiltroTipoArt.Items.Clear();
            ComboBoxFiltroTipoArt.Items.Add("Todos");
            ComboBoxFiltroTipoArt.StartIndex = 0;
            List<ModeloTipoArticulo> T_Articulo = Info.TiposArticulo();
            foreach (var Tipo in T_Articulo)
            {
                ComboBoxFiltroTipoArt.Items.Add(Tipo._Nombre_Tipo);
            }

            ComboBoxFiltroTipoStats.Items.Clear();
            ComboBoxFiltroTipoStats.Items.Add("Todos");
            ComboBoxFiltroTipoStats.StartIndex = 0;
            List<ModeloTipoStats> T_Stats = Info.TipoStats();
            foreach (var Tipo in T_Stats)
            {
                ComboBoxFiltroTipoStats.Items.Add(Tipo._Nombre_TipoS);
            }

            ComboBoxFiltroModoStatsArt.Items.Clear();
            ComboBoxFiltroModoStatsArt.Items.Add("Todos");
            ComboBoxFiltroModoStatsArt.StartIndex = 0;
            List<ModeloModoStats> M_Stats = Info.ModoStats();
            foreach (var Modo in M_Stats)
            {
                ComboBoxFiltroModoStatsArt.Items.Add(Modo._Modo_Stats);
            }

        }
        private void RellenarTablaArticulos(List<ModeloArticulos> Articulo)
        {
            DataGridArticulos.Rows.Clear();
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
        private void GuardarArticulo()
        {
            Reportes_y_Validaciones.Validaciones Validar = new Reportes_y_Validaciones.Validaciones();
            QuitarErroresArticulos();
            bool Validado = true;

            if (!Validar.NoCamposVacios(IDArticuloTextBox.Text) || !Validar.RangoCaracteres(IDArticuloTextBox.Text, 3, 20) || !Validar.StringNumber(IDArticuloTextBox.Text))
            {
                ErrorIDArticulo.Visible = true;
                Validado = false;
            }
            if (!Validar.NoCamposVacios(NombreArticuloTextBox.Text) || !Validar.RangoCaracteres(NombreArticuloTextBox.Text, 3, 20) || !Validar.StringNumber(NombreArticuloTextBox.Text))
            {
                ErrorNombreArticulo.Visible = true;
                Validado = false;
            }
            if (!Validar.NoCamposVacios(URLArticulo))
            {
                ErrorImagenArticulo.Visible = true;
                Validado = false;
            }
            if (ComboBoxTipoArticulo.SelectedIndex == 0)
            {
                ErrorTipoArticulo.Visible = true;
                Validado = false;
            }
            if (ComboBoxStat.SelectedIndex == 0)
            {
                ErrorTipoStats.Visible = true;
                Validado = false;
            }
            if (StatArticulo.Value > 100 && ComboBoxPTS.SelectedIndex == 1)
            {
                ErrorCantStats.Visible = true;
                Validado = false;
            }
            if (ComboBoxPTS.SelectedIndex == 0)
            {
                ErrorModoStats.Visible = true;
                Validado = false;
            }

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
                            Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Modificado el Articulo " + NewArticulo._idArticulo);
                            Control.AñadirBitacora(Bitacora);
                            LimpiarTextosArticulos();
                        }
                        break;
                    }
                }
                if (!Coincidencia)
                {
                    Control.AgregarModificarArticulo(NewArticulo, true);
                    GunaMessageBoxOK.Show("Articulo agregado exitosamente", "¡Exito!");
                    Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Creado el Articulo " + NewArticulo._idArticulo);
                    Control.AñadirBitacora(Bitacora);
                    LimpiarTextosArticulos();
                }
                CopiarImagenLocal(URLArticulo, Guardar);
            }
        }
        private void GenerarReporteArticulos(List<ModeloArticulos> ListaArticulos, string Filtro)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "ReporteArticulos_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            Guardar.Filter = "Documento PDF|*.pdf";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Controladores.Reportes Reporte = new Controladores.Reportes();
                Reporte.ReporteArticulos(Guardar.FileName, ListaArticulos, Filtro);
                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Exportado el registro de Articulos");
                ControladorAdmin GuardarInfo = new ControladorAdmin();
                GuardarInfo.AñadirBitacora(Bitacora);
                GunaMessageBoxOK.Show("Reporte exportado exitosamente.", "Información.");
            }
        }
        private void BuscarFiltroArticulos()
        {
            ControladorAdmin Info = new ControladorAdmin();
            RellenarTablaArticulos(Info.FiltroArticulos(TextBoxFiltroIDArticulo.Text, TextBoxFiltroNombreArticulo.Text, ComboBoxFiltroTipoArt.Text, ComboBoxFiltroTipoStats.Text, Convert.ToInt32(NumericFiltroDEArticulo.Value), Convert.ToInt32(NumericFiltroHastaArticulo.Value), ComboBoxFiltroModoStatsArt.Text, ComboBoxFiltroActivoArticulo.SelectedIndex, ComboBoxFiltroOrdenArticulos.SelectedIndex));
        }
        private void LimpiarFiltrosArticulos()
        {
            TextBoxFiltroIDArticulo.Text = "";
            TextBoxFiltroNombreArticulo.Text = "";
            ComboBoxFiltroTipoArt.SelectedIndex = 0;
            ComboBoxFiltroTipoStats.SelectedIndex = 0;
            NumericFiltroDEArticulo.Value = 1;
            NumericFiltroHastaArticulo.Value = 999;
            ComboBoxFiltroModoStatsArt.SelectedIndex = 0;
            ComboBoxFiltroActivoArticulo.SelectedIndex = 0;
            ComboBoxFiltroOrdenArticulos.SelectedIndex = 0;
        }
        private void QuitarErroresArticulos()
        {
            ErrorImagenArticulo.Visible = false;
            ErrorIDArticulo.Visible = false;
            ErrorNombreArticulo.Visible = false;
            ErrorTipoArticulo.Visible = false;
            ErrorTipoStats.Visible = false;
            ErrorCantStats.Visible = false;
            ErrorModoStats.Visible = false;
        }

        #endregion

        #region Eventos Articulos

        bool btnregresoArticulo, btnlimpiarArticulo, btnguardarArticulo;

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
                    LabelCrearArticulo.Text = "Modificar Articulo";
                    TabControlAll.SelectTab("TpCrearArticulos");

                }
            }

            if (e.ColumnIndex == DataGridArticulos.Columns.IndexOf(MostrarArticulos))
            {
                if (e.RowIndex != -1)
                {
                    Control.OcultarArticulo(DataGridArticulos.CurrentRow.Cells["IDArticulo"].Value.ToString(), Convert.ToBoolean(DataGridArticulos.CurrentRow.Cells["ActivoArticulo"].Value));
                    RellenarTablaArticulos(Articulos);
                }
            }
        }

        #endregion

        #endregion

        #region Reportes

        #region Funciones Reportes

        private void RellenarGraficoIzq()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<Modelos.ModeloRangoCantidad> RangoCantidad = new List<Modelos.ModeloRangoCantidad>();
            ArrayList Rangos = new ArrayList();
            ArrayList Cantidad = new ArrayList();

            RangoCantidad = Info.RangoUsuariosGraficoIzq(DatePickGrafDeIzq.Value.ToString("yyyy-MM-dd"), DatePickGrafHastaIzq.Value.ToString("yyyy-MM-dd"), ComboBoxRangoIzq.SelectedIndex, false);
            foreach (var Rang in RangoCantidad)
            {
                Rangos.Add(Rang._Rango);
                Cantidad.Add(Rang._Cantidad);
            }
            ChartIzq.Series[0].Points.DataBindXY(Rangos, Cantidad);

            List<Modelos.ModeloRangoCantidad> RangoCantidad2 = new List<Modelos.ModeloRangoCantidad>();
            ArrayList Rangos2 = new ArrayList();
            ArrayList Cantidad2 = new ArrayList();
            ArrayList Rangos3 = new ArrayList();
            ArrayList Cantidad3 = new ArrayList();

            RangoCantidad2 = Info.RangoUsuariosGraficoIzq(DatePickGrafDeIzq.Value.ToString("yyyy-MM-dd"), DatePickGrafHastaIzq.Value.ToString("yyyy-MM-dd"), ComboBoxRangoIzq.SelectedIndex, true);
            for (int i = 0; i < RangoCantidad.Count; i++)
            {
                string RangoCoincidido = "";
                int CantidadCoincidida = 0;
                int CantidadCoincidida2 = 0;

                bool Coincidio = false;

                for (int j = 0; j < RangoCantidad2.Count; j++)
                {
                    if (RangoCantidad[i]._Rango == RangoCantidad2[j]._Rango)
                    {
                        RangoCoincidido = RangoCantidad2[j]._Rango;
                        CantidadCoincidida = RangoCantidad2[j]._Cantidad;
                        CantidadCoincidida2 = RangoCantidad[i]._Cantidad - RangoCantidad2[j]._Cantidad;
                        Coincidio = true;
                        break;
                    }
                }
                if (Coincidio)
                {
                    Rangos2.Add(RangoCoincidido);
                    Cantidad2.Add(CantidadCoincidida);
                    Rangos3.Add(RangoCoincidido);
                    Cantidad3.Add(CantidadCoincidida2);
                }
                else
                {
                    Rangos2.Add(RangoCantidad[i]._Rango);
                    Cantidad2.Add(0);
                    Rangos3.Add(RangoCantidad[i]._Rango);
                    Cantidad3.Add(RangoCantidad[i]._Cantidad);
                }
            }

            ChartIzq.Series[1].Points.DataBindXY(Rangos2, Cantidad2);
            ChartIzq.Series[2].Points.DataBindXY(Rangos3, Cantidad3);
        }

        private void RellenarSegundoGrafIzq()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<Modelos.ModeloRangoCantidad> RangoCantidad = Info.RangoCantidadDe(-1);
            ArrayList RangoATQ = new ArrayList();
            ArrayList CantidadATQ = new ArrayList();
            ArrayList RangoDEF = new ArrayList();
            ArrayList CantidadDEF = new ArrayList();
            ArrayList RangoHPMax = new ArrayList();
            ArrayList CantidadHPMax = new ArrayList();
            ArrayList RangoMoney = new ArrayList();
            ArrayList CantidadMoney = new ArrayList();

            foreach (var Desglosar in RangoCantidad)
            {
                switch (Desglosar._Stat)
                {
                    case "Ataque":
                        RangoATQ.Add(Desglosar._Rango);
                        CantidadATQ.Add(Desglosar._Cantidad);
                        RangoDEF.Add(Desglosar._Rango);
                        CantidadDEF.Add(null);
                        RangoHPMax.Add(Desglosar._Rango);
                        CantidadHPMax.Add(null);
                        RangoMoney.Add(Desglosar._Rango);
                        CantidadMoney.Add(null);
                        break;
                    case "Defensa":
                        RangoATQ.Add(Desglosar._Rango);
                        CantidadATQ.Add(null);
                        RangoDEF.Add(Desglosar._Rango);
                        CantidadDEF.Add(Desglosar._Cantidad);
                        RangoHPMax.Add(Desglosar._Rango);
                        CantidadHPMax.Add(null);
                        RangoMoney.Add(Desglosar._Rango);
                        CantidadMoney.Add(null);
                        break;
                    case "VidaMax":
                        RangoATQ.Add(Desglosar._Rango);
                        CantidadATQ.Add(null);
                        RangoDEF.Add(Desglosar._Rango);
                        CantidadDEF.Add(null);
                        RangoHPMax.Add(Desglosar._Rango);
                        CantidadHPMax.Add(Desglosar._Cantidad);
                        RangoMoney.Add(Desglosar._Rango);
                        CantidadMoney.Add(null);
                        break;
                    case "Monedas":
                        RangoATQ.Add(Desglosar._Rango);
                        CantidadATQ.Add(null);
                        RangoDEF.Add(Desglosar._Rango);
                        CantidadDEF.Add(null);
                        RangoHPMax.Add(Desglosar._Rango);
                        CantidadHPMax.Add(null);
                        RangoMoney.Add(Desglosar._Rango);
                        CantidadMoney.Add(Desglosar._Cantidad);
                        break;
                }
            }

            ChartIzq2.Series[0].Points.DataBindXY(RangoATQ, CantidadATQ);
            ChartIzq2.Series[1].Points.DataBindXY(RangoDEF, CantidadDEF);
            ChartIzq2.Series[2].Points.DataBindXY(RangoHPMax, CantidadHPMax);
            ChartIzq2.Series[3].Points.DataBindXY(RangoMoney, CantidadMoney);

        }

        private void RellenarGraficoDer()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<Modelos.ModeloRangoCantidad> RangoCantidad = new List<Modelos.ModeloRangoCantidad>();
            ArrayList Rangos = new ArrayList();
            ArrayList Cantidad = new ArrayList();

            RangoCantidad = Info.RangoCantidadDe(ComboBoxOpcionDer.SelectedIndex);
            foreach (var Rang in RangoCantidad)
            {
                Rangos.Add(Rang._Rango);
                Cantidad.Add(Rang._Cantidad);
            }
            ChartDer.Series[0].Points.DataBindXY(Rangos, Cantidad);
        }

        private void RellenarGraficosEstaticos()
        {
            ArrayList Rangos = new ArrayList() {"Manzano", "Peral", "Duraznero", "Naranjo"};
            ArrayList Cantidad = new ArrayList() {2, 6, 3, 8};
            ChartDer2.Series[0].Points.DataBindXY(Rangos, Cantidad);

            Rangos.Clear();
            Cantidad.Clear();
            Rangos = new ArrayList() { "Excelente", "Bueno", "Decente", "Regular", "Malo", "Pesimo" };
            Cantidad = new ArrayList() { 3, 8, 2, 1, 2, 0 };
            ChartIzq3.Series[0].Points.DataBindXY(Rangos, Cantidad);

            Rangos.Clear();
            Cantidad.Clear();
            Rangos = new ArrayList() { "Excelente", "Bueno", "Decente", "Regular", "Malo", "Pesimo" };
            Cantidad = new ArrayList() { 5, 6, 2, 2, 0, 1 };
            ChartIzq3.Series[1].Points.DataBindXY(Rangos, Cantidad);

            Rangos.Clear();
            Cantidad.Clear();
            Rangos = new ArrayList() { "Excelente", "Bueno", "Decente", "Regular", "Malo", "Pesimo" };
            Cantidad = new ArrayList() { 8, 4, 1, 2, 0, 1 };
            ChartIzq3.Series[2].Points.DataBindXY(Rangos, Cantidad);

            Rangos.Clear();
            Cantidad.Clear();
            Rangos = new ArrayList() { "Excelente", "Bueno", "Decente", "Regular", "Malo", "Pesimo" };
            Cantidad = new ArrayList() { 2, 4, 6, 1, 3, 0 };
            ChartIzq3.Series[3].Points.DataBindXY(Rangos, Cantidad);

            Rangos.Clear();
            Cantidad.Clear();
            Rangos = new ArrayList() { "AdnCrazy", "Magda", "ImKaos", "MikeSloval", "AswagerKgzk" };
            Cantidad = new ArrayList() { 7, 20, 31, 33, 40 };
            ChartDer3.Series[0].Points.DataBindXY(Rangos, Cantidad);
        }

        private void RellenarTotales()
        {
            ControladorAdmin Info = new ControladorAdmin();
            LabelCantTotalUsuarios.Text = Info.CantidadTotalDe(1).ToString();
            LabelCantTotalArticulos.Text = Info.CantidadTotalDe(2).ToString();
        }

        #endregion

        #region Eventos Reportes

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

        private void ComboBoxOpcionDer_SelectedValueChanged(object sender, EventArgs e)
        {
            RellenarGraficoDer();
        }

        int r = 120, g = 120, b = 120;
        bool reversa = false;

        private void CambiarColor_Tick(object sender, EventArgs e)
        {
            if (!reversa)
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

        #region Actualizaciones

        #region Botnones Actualizaciones

        bool ModificarTipoArticulo = false;
        bool ModificarTipoStats = false;
        bool ModificarModoStats = false;

        private void BotonAddTipoArticulo_Click(object sender, EventArgs e)
        {
            CambioPanelTipoArticulo();
            ModificarTipoArticulo = false;
        }

        private void BotonUpdateTipoArticulo_Click(object sender, EventArgs e)
        {
            CambioPanelTipoArticulo();
            ModificarTipoArticulo = true;
        }

        private void BotonConfirmarTipoArticulo_Click(object sender, EventArgs e)
        {
            ConfirmarTipoArticulo();
        }

        private void BotonAddTipoStats_Click(object sender, EventArgs e)
        {
            CambioPanelTipoStats();
            ModificarTipoStats = false;
        }

        private void BotonUpdateTipoStats_Click(object sender, EventArgs e)
        {
            CambioPanelTipoStats();
            ModificarTipoStats = true;
        }

        private void BotonCancelTipoArticulo_Click(object sender, EventArgs e)
        {
            CambioPanelTipoArticulo();
        }

        private void BotonConfirmarTipoStats_Click(object sender, EventArgs e)
        {
            ConfirmarTipoStats();
        }
        private void BotonCancelTipoStats_Click(object sender, EventArgs e)
        {
            CambioPanelTipoStats();
        }

        private void BotonAddModoStats_Click(object sender, EventArgs e)
        {
            CambioPanelModoStats();
            ModificarModoStats = false;
        }

        private void BotonUpdateModoStats_Click(object sender, EventArgs e)
        {
            CambioPanelModoStats();
            ModificarModoStats = true;
        }

        private void BotonConfirmarModoStats_Click(object sender, EventArgs e)
        {
            ConfirmarModoStats();
        }

        private void BotonCancelModoStats_Click(object sender, EventArgs e)
        {
            CambioPanelModoStats();
        }

        #endregion

        #region Funciones Actualizacion

        private void ConfirmarTipoArticulo()
        {
            if (TextBoxAggTipoArticulo.Text.Length >= 3 && TextBoxAggTipoArticulo.Text.Length <= 10)
            {
                ModeloTipoArticulo NewTipo = new ModeloTipoArticulo();
                ControladorAdmin Info = new ControladorAdmin();
                if (!ModificarTipoArticulo)
                {
                    bool Coincidir = false;
                    List<ModeloTipoArticulo> Comprobar = Info.TiposArticulo();

                    NewTipo._idTipo_Articulo = "TIPO_" + TextBoxAggTipoArticulo.Text.ToUpper();
                    NewTipo._Nombre_Tipo = TextBoxAggTipoArticulo.Text;
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (NewTipo._idTipo_Articulo == Coincidencia._idTipo_Articulo.ToUpper())
                        {
                            Coincidir = true;
                            break;
                        }
                    }
                    if (!Coincidir)
                    {
                        Info.AgregarModificarTipoArticulo(NewTipo, ModificarTipoArticulo);
                        GunaMessageBoxOK.Show("Registrado exitosamente.", "Información");
                        Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Creado el tipos de Articulo " + NewTipo._Nombre_Tipo);
                        Info.AñadirBitacora(Bitacora);
                        RellenarItemsDatos();
                        CambioPanelTipoArticulo();
                    }
                    else
                    {
                        GunaMessageBoxOK.Show("Ya existe existe ese tipo.", "Información");
                    }
                }
                else
                {
                    List<ModeloTipoArticulo> Comprobar = Info.TiposArticulo();
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (ComboBoxTiposArticuloAgg.Text == Coincidencia._Nombre_Tipo)
                        {
                            DialogResult Respuesta = GunaMessageBox.Show("¿Seguro quieres cambiar " + ComboBoxTiposArticuloAgg.Text + " por " + TextBoxAggTipoArticulo.Text + "?", "¡Alerta!");
                            if (Respuesta == DialogResult.Yes)
                            {
                                NewTipo._idTipo_Articulo = Coincidencia._idTipo_Articulo;
                                NewTipo._Nombre_Tipo = TextBoxAggTipoArticulo.Text;
                                Info.AgregarModificarTipoArticulo(NewTipo, ModificarTipoArticulo);
                                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Modificado el tipo de Articulo de " + ComboBoxTiposArticuloAgg.Text + " a " + NewTipo._Nombre_Tipo);
                                Info.AñadirBitacora(Bitacora);
                                RellenarItemsDatos();
                                CambioPanelTipoArticulo();
                            }
                            break;
                        }
                    }
                }
            }

        }

        private void ConfirmarTipoStats()
        {
            if (TextBoxAggTipoStats.Text.Length >= 2 && TextBoxAggTipoStats.Text.Length <= 5)
            {
                ModeloTipoStats NewTipo = new ModeloTipoStats();
                ControladorAdmin Info = new ControladorAdmin();
                if (!ModificarTipoStats)
                {
                    bool Coincidir = false;
                    List<ModeloTipoStats> Comprobar = Info.TipoStats();

                    NewTipo._idTipo_Stats = "TIPO_" + TextBoxAggTipoStats.Text.ToUpper();
                    NewTipo._Nombre_TipoS = TextBoxAggTipoStats.Text;
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (NewTipo._idTipo_Stats == Coincidencia._idTipo_Stats.ToUpper())
                        {
                            Coincidir = true;
                            break;
                        }
                    }
                    if (!Coincidir)
                    {
                        Info.AgregarModificarTipoStats(NewTipo, ModificarTipoStats);
                        GunaMessageBoxOK.Show("Registrado exitosamente.", "Información");
                        Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Añadido el tipo de Estadistica " + NewTipo._Nombre_TipoS);
                        Info.AñadirBitacora(Bitacora);
                        RellenarItemsDatos();
                        CambioPanelTipoStats();
                    }
                    else
                    {
                        GunaMessageBoxOK.Show("Ya existe existe ese tipo.", "Información");
                    }
                }
                else
                {
                    List<ModeloTipoStats> Comprobar = Info.TipoStats();
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (ComboBoxTipoEstadisticaAgg.Text == Coincidencia._Nombre_TipoS)
                        {
                            DialogResult Respuesta = GunaMessageBox.Show("¿Seguro quieres cambiar " + ComboBoxTipoEstadisticaAgg.Text + " por " + TextBoxAggTipoStats.Text + "?", "¡Alerta!");
                            if (Respuesta == DialogResult.Yes)
                            {
                                NewTipo._idTipo_Stats = Coincidencia._idTipo_Stats;
                                NewTipo._Nombre_TipoS = TextBoxAggTipoStats.Text;
                                Info.AgregarModificarTipoStats(NewTipo, ModificarTipoStats);
                                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Modificado el tipo de Estadistica de " + ComboBoxTipoEstadisticaAgg.Text + " a " + NewTipo._Nombre_TipoS);
                                Info.AñadirBitacora(Bitacora);
                                RellenarItemsDatos();
                                CambioPanelTipoStats();
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void ConfirmarModoStats()
        {
            if (TextBoxAggModoStats.Text.Length >= 1 && TextBoxAggModoStats.Text.Length <= 4)
            {
                ModeloModoStats NewModo = new ModeloModoStats();
                ControladorAdmin Info = new ControladorAdmin();
                if (!ModificarModoStats)
                {
                    bool Coincidir = false;
                    List<ModeloModoStats> Comprobar = Info.ModoStats();

                    NewModo._idModo_Stats = "MODO_" + TextBoxAggModoStats.Text.ToUpper();
                    NewModo._Modo_Stats = TextBoxAggModoStats.Text;
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (NewModo._idModo_Stats == Coincidencia._idModo_Stats.ToUpper())
                        {
                            Coincidir = true;
                            break;
                        }
                    }
                    if (!Coincidir)
                    {
                        Info.AgregarModificarModoStats(NewModo, ModificarModoStats);
                        GunaMessageBoxOK.Show("Registrado exitosamente.", "Información");
                        Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Añadido el Modo de Estadistica " + NewModo._Modo_Stats);
                        Info.AñadirBitacora(Bitacora);
                        RellenarItemsDatos();
                        CambioPanelModoStats();
                    }
                    else
                    {
                        GunaMessageBoxOK.Show("Ya existe existe ese Modo.", "Información");
                    }
                }
                else
                {
                    List<ModeloModoStats> Comprobar = Info.ModoStats();
                    foreach (var Coincidencia in Comprobar)
                    {
                        if (ComboBoxAggModoStats.Text == Coincidencia._Modo_Stats)
                        {
                            DialogResult Respuesta = GunaMessageBox.Show("¿Seguro quieres cambiar " + ComboBoxAggModoStats.Text + " por " + TextBoxAggModoStats.Text + "?", "¡Alerta!");
                            if (Respuesta == DialogResult.Yes)
                            {
                                NewModo._idModo_Stats = Coincidencia._idModo_Stats;
                                NewModo._Modo_Stats = TextBoxAggModoStats.Text;
                                Info.AgregarModificarModoStats(NewModo, ModificarModoStats);
                                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Modificado el Modo de Estadistica de " + ComboBoxAggModoStats.Text + " a " + NewModo._Modo_Stats);
                                Info.AñadirBitacora(Bitacora);
                                RellenarItemsDatos();
                                CambioPanelModoStats();
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void RellenarItemsDatos()
        {
            ControladorAdmin Info = new ControladorAdmin();
            List<ModeloTipoArticulo> TiposArticulo = Info.TiposArticulo();
            List<ModeloTipoStats> TiposStats = Info.TipoStats();
            List<ModeloModoStats> ModoStats = Info.ModoStats();
            ComboBoxTiposArticuloAgg.Items.Clear();
            ComboBoxTipoEstadisticaAgg.Items.Clear();
            ComboBoxAggModoStats.Items.Clear();

            foreach (var Agg in TiposArticulo)
            {
                ComboBoxTiposArticuloAgg.Items.Add(Agg._Nombre_Tipo);
            }
            foreach (var Agg in TiposStats)
            {
                ComboBoxTipoEstadisticaAgg.Items.Add(Agg._Nombre_TipoS);
            }
            foreach (var Agg in ModoStats)
            {
                ComboBoxAggModoStats.Items.Add(Agg._Modo_Stats);
            }
            ComboBoxTiposArticuloAgg.SelectedIndex = 0;
            ComboBoxTipoEstadisticaAgg.SelectedIndex = 0;
            ComboBoxAggModoStats.SelectedIndex = 0;
        }

        private void CambioPanelTipoArticulo()
        {
            if (ComboBoxTiposArticuloAgg.Visible == false)
            {
                ComboBoxTiposArticuloAgg.Visible = true;
                PanelCUDTipoArticulo.Visible = true;
                TextBoxAggTipoArticulo.Visible = false;
                PanelConfirmTipoArticulo.Visible = false;
            }
            else
            {
                ComboBoxTiposArticuloAgg.Visible = false;
                PanelCUDTipoArticulo.Visible = false;
                TextBoxAggTipoArticulo.Text = string.Empty;
                TextBoxAggTipoArticulo.Visible = true;
                PanelConfirmTipoArticulo.Visible = true;
            }
        }

        private void CambioPanelTipoStats()
        {
            if (ComboBoxTipoEstadisticaAgg.Visible == false)
            {
                ComboBoxTipoEstadisticaAgg.Visible = true;
                PanelCUDTipoStats.Visible = true;
                TextBoxAggTipoStats.Visible = false;
                PanelConfirmTipoStats.Visible = false;
            }
            else
            {
                ComboBoxTipoEstadisticaAgg.Visible = false;
                PanelCUDTipoStats.Visible = false;
                TextBoxAggTipoStats.Text = string.Empty;
                TextBoxAggTipoStats.Visible = true;
                PanelConfirmTipoStats.Visible = true;
            }
        }

        private void CambioPanelModoStats()
        {
            if (ComboBoxAggModoStats.Visible == false)
            {
                ComboBoxAggModoStats.Visible = true;
                PanelCUDModoStats.Visible = true;
                TextBoxAggModoStats.Visible = false;
                PanelConfirmModoStats.Visible = false;
            }
            else
            {
                ComboBoxAggModoStats.Visible = false;
                PanelCUDModoStats.Visible = false;
                TextBoxAggModoStats.Text = string.Empty;
                TextBoxAggModoStats.Visible = true;
                PanelConfirmModoStats.Visible = true;
            }
        }

        private void DatosxDefecto()
        {
            ComboBoxTiposArticuloAgg.Visible = false;
            ComboBoxTipoEstadisticaAgg.Visible = false;
            ComboBoxAggModoStats.Visible = false;
            CambioPanelTipoArticulo();
            CambioPanelTipoStats();
            CambioPanelModoStats();
        }

        #endregion

        #endregion

        #region Registros

        #region Botones Registro

        private void BotonLimpiarFiltroRegistro_Click(object sender, EventArgs e)
        {
            LimpiarFiltrosRegistros();
        }

        private void BotonBuscarFiltroRegistro_Click(object sender, EventArgs e)
        {
            ControladorAdmin Info = new ControladorAdmin();
            RellenarRegistros(Info.FiltroRegistros(TextBoxFiltroIDRegistro.Text, TextBoxFiltroUsuarioRegistro.Text, DatePickFiltroDesdeRegistro.Value.ToString("yyyy-MM-dd"), DatePickFiltroHastaRegistro.Value.ToString("yyyy-MM-dd"), ComboBoxFiltroMovimientos.SelectedIndex, ComboBoxFiltroOrdenRegistro.Text));
        }
        private void BotonReporteFiltroRegistro_Click(object sender, EventArgs e)
        {
            ControladorAdmin Info = new ControladorAdmin();
            GenerarReporteRegistros(Info.FiltroRegistros(TextBoxFiltroIDRegistro.Text, TextBoxFiltroUsuarioRegistro.Text, DatePickFiltroDesdeRegistro.Value.ToString("yyyy-MM-dd"), DatePickFiltroHastaRegistro.Value.ToString("yyyy-MM-dd"), ComboBoxFiltroMovimientos.SelectedIndex, ComboBoxFiltroOrdenRegistro.Text), ComboBoxFiltroOrdenRegistro.Text);
        }

        #endregion

        #region Funciones Registro

        private void LimpiarFiltrosRegistros()
        {
            TextBoxFiltroIDArticulo.Text = "";
            TextBoxFiltroUsuarioRegistro.Text = "";
            DatePickFiltroDesdeRegistro.Value = Convert.ToDateTime("2024-01-01");
            DatePickFiltroHastaRegistro.Value = DateTime.Now;
            ComboBoxFiltroMovimientos.SelectedIndex = 0;
        }

        private void RellenarRegistros(List<Modelos.ModeloRegistroActividad> Filtro)
        {
            DataGridRegistrosActividad.Rows.Clear();
            foreach (var Registros in Filtro)
            {
                DataGridRegistrosActividad.Rows.Add(Registros._idRegistro, Registros._idUsuario, Registros._Descripcion, Registros._FechaRegistro.ToString());
            }
        }

        private void GenerarReporteRegistros(List<Modelos.ModeloRegistroActividad> ListaRegistros, string Filtro)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "ReporteRegistros_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            Guardar.Filter = "Documento PDF|*.pdf";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Controladores.Reportes Reporte = new Controladores.Reportes();
                Reporte.ReporteRegistros(Guardar.FileName, ListaRegistros, Filtro);
                Modelos.ModeloRegistroActividad Bitacora = new Modelos.ModeloRegistroActividad(NombreUsuario, "Ha Exportado el reporte de Registros");
                ControladorAdmin GuardarInfo = new ControladorAdmin();
                GuardarInfo.AñadirBitacora(Bitacora);
                GunaMessageBoxOK.Show("Reporte exportado exitosamente.", "Información.");
            }
        }

        #endregion

        #endregion

        #region Configuracion

        #region Botones Configuracion

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

        #endregion

        #region Perfil

        #region Funciones Perfil

        private void RellenarPerfil(ModeloCuentaUsuario Cuenta)
        {
            LabelUsuarioPerfil.Text = Cuenta._idUsuario;
            BarraProgresoVidaPerfil.Maximum = Cuenta._VidaMax;
            BarraProgresoVidaPerfil.Value = Cuenta._Vida;
            BarraProgresoVidaPerfil.Text = Cuenta._Vida + " / " + Cuenta._VidaMax;
            BarraProgresoEXPPerfil.Value = Cuenta._Experiencia;
            BarraProgresoEXPPerfil.Text = Cuenta._Experiencia + " / " + "100";
            LabelMonedasPerfil.Text = Cuenta._Monedas.ToString();
            LabelEnergiaPerfil.Text = Cuenta._Energia.ToString(); ;
            LabelPTSAtaquePerfil.Text = Cuenta._Ataque.ToString();
            LabelPTSDefensaPerfil.Text = Cuenta._Defensa.ToString();
            LabelPTSEspacioPerfil.Text = Cuenta._EspacioInv.ToString();
            LabelPTSTiempoPerfil.Text = Cuenta._TiempoJugado_Mins.ToString();
        }

        #endregion

        #endregion
    }
}

#region Comentarios

/*--------------------------------------------------------------------------------------------------------

[ Linea 24 - Linea 78 = Region del Formulario. Se ubica los evento para: ]

    Linea 28 - Linea 38 = (Iniciar App) Inicia el modulo, hace unos ajustes para actualizarlos al dia.
    Linea 46 - Linea 58 = Mover formulario.
    Linea 59 - Linea 65 = Cambio de tamaño.
    Linea 66 - Linea 74 = Pregunta de seguridad para salir.

----------------------------------------------------------------------------------------------------------

[ Linea 80 - Linea 245 =  Region del Menu. Se ubican las funciones: ]

    Linea 82 - Linea 160 = Todos los botones para cambiar de modulo, quitar bordes, habilitar el borde del
                           modulo y rellenar campos de los modulos correspondientes.
    Linea 164 - Linea 168 = (Minimizar Panel) Activa el evento de tiempo para reducir el tamaño del menú.
    Linea 169 - Linea 172 = (Maximizar Panel) Vuelve a activar el evento de tiempo pero para reducir el 
                            tamaño del menú.
    Linea 173 - Linea 185 = (Quitar bordes) Quita los bordes de los botones para que no se visualice
                            al cambiar de tappages en el menú.
    Linea 186 - Linea 198 = (Quitar nombres) Quita los nombres de los botones para que no se visualice
                            al minimizar el panel del menú.
    Linea 199 - Linea 211 = (Mostrar Nombres) Coloca los nombres de los TAG's de los botones para que
                            se visualicen al extender el panel del menú.
    Linea 219 - Linea 240 = Evento de tiempo para realizar la animación de extender y reducir el tamaño
                            del panel del menú para visualizar mejor los nombres de cada modulo.

----------------------------------------------------------------------------------------------------------

[ Linea 246 - Linea 248 = Region del Home. Nada por ahora, solo esta apartado para alguna modificación ]

----------------------------------------------------------------------------------------------------------

[ Linea 250 - Linea 597 = Region de los Usuarios. Se ubican las funciones: ]

    Linea 252 - Linea 326 = Todos los botones para cambiar a otro modulo, modificar, guardar o limpiar
                            alguna propiedad del diseño.
    Linea 330 - Linea 341 = (Rellenar Combo Rol) Funcion para rellenar el combobox de los roles.
    Linea 342 - Linea 353 = (Rellenar Combo Rol Filtro) Rellena el del fintro de la tabla de busqueda. 
    Linea 354 - Linea 370 = (Rellenar Tabla Usuarios) Recibe de parametro una lista de usuarios para
                            rellenar en la tabla con todos sus campos excepto la contraseña.
    Linea 371 - Linea 378 = (Quitar errores usuario) Desvisualiza las imagenes de error del formulario
                            donde se crea o modifica el usuario.
    Linea 379 - Linea 387 = (Limpiar textos) Quita los valores escritos del formulario.
    Linea 388 - Linea 453 = (Verificar y crear usuario) Aplica validaciones y verifica si esta todo
                            correcto o revisa si hay algun usuario ya existente para crear o modificar
                            al controlador.
    Linea 454 - Linea 463 = (Limpiar filtro user) Quita los valores escritos del filtro de la tabla. 
    Linea 464 - Linea 469 = (Buscar Filtro) Agarra los valores del filtro para realizar una busqueda a
                            través del controlador a la base de datos.
    Linea 470 - Linea 484 = (Generar Reporte Usuarios) Recibe de parametro la lista de objetos filtrada
                            de la tabla y el filtro de orden que se aplicó para generar un reporte.
    Linea 492 - Linea 532 = Evento para mover los botones del formulario para que se visualice el
                            significado del icono.
    Linea 538 - Linea 589 = Evento de click en celda de la tabla de usuarios en el que revisa si la celda
                            seleccionada sea de una columna especifica para generar una funcion sea de 
                            modificar, bloquear o ver perfil.

----------------------------------------------------------------------------------------------------------

Linea - Linea = 
Linea - Linea = 
Linea - Linea = 
Linea - Linea = 
Linea - Linea = 
Linea - Linea = 
Linea - Linea = 
Linea - Linea = 

*/

#endregion
