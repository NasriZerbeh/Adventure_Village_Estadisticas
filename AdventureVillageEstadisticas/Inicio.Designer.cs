
namespace AdventureVillageEstadisticas
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.ControlCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlMaximizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PanelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.PanelSalida = new Guna.UI2.WinForms.Guna2Panel();
            this.BotonSalir = new Guna.UI2.WinForms.Guna2Button();
            this.PanelOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.BotonOpciones = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHome = new Guna.UI2.WinForms.Guna2Panel();
            this.BotonHome = new Guna.UI2.WinForms.Guna2Button();
            this.SeparadorHome = new Guna.UI2.WinForms.Guna2Separator();
            this.PanelInicio = new Guna.UI2.WinForms.Guna2Panel();
            this.BotonMenu = new Guna.UI2.WinForms.Guna2Button();
            this.AnimacionMenu = new System.Windows.Forms.Timer(this.components);
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.PanelControl.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelSalida.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.PanelInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlCerrar
            // 
            this.ControlCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlCerrar.Animated = true;
            this.ControlCerrar.BorderRadius = 5;
            this.ControlCerrar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ControlCerrar.FillColor = System.Drawing.Color.ForestGreen;
            this.ControlCerrar.IconColor = System.Drawing.Color.White;
            this.ControlCerrar.Location = new System.Drawing.Point(774, 6);
            this.ControlCerrar.Name = "ControlCerrar";
            this.ControlCerrar.Size = new System.Drawing.Size(20, 20);
            this.ControlCerrar.TabIndex = 0;
            // 
            // ControlMinimizar
            // 
            this.ControlMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMinimizar.Animated = true;
            this.ControlMinimizar.BorderRadius = 5;
            this.ControlMinimizar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ControlMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMinimizar.FillColor = System.Drawing.Color.ForestGreen;
            this.ControlMinimizar.IconColor = System.Drawing.Color.White;
            this.ControlMinimizar.Location = new System.Drawing.Point(732, 6);
            this.ControlMinimizar.Name = "ControlMinimizar";
            this.ControlMinimizar.Size = new System.Drawing.Size(20, 20);
            this.ControlMinimizar.TabIndex = 1;
            // 
            // ControlMaximizar
            // 
            this.ControlMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMaximizar.Animated = true;
            this.ControlMaximizar.BorderRadius = 5;
            this.ControlMaximizar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ControlMaximizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlMaximizar.FillColor = System.Drawing.Color.ForestGreen;
            this.ControlMaximizar.IconColor = System.Drawing.Color.White;
            this.ControlMaximizar.Location = new System.Drawing.Point(753, 6);
            this.ControlMaximizar.Name = "ControlMaximizar";
            this.ControlMaximizar.Size = new System.Drawing.Size(20, 20);
            this.ControlMaximizar.TabIndex = 2;
            // 
            // PanelControl
            // 
            this.PanelControl.Controls.Add(this.ControlMaximizar);
            this.PanelControl.Controls.Add(this.ControlCerrar);
            this.PanelControl.Controls.Add(this.ControlMinimizar);
            this.PanelControl.CustomBorderColor = System.Drawing.Color.Red;
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(800, 30);
            this.PanelControl.TabIndex = 4;
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.Controls.Add(this.guna2Separator1);
            this.PanelMenu.Controls.Add(this.PanelSalida);
            this.PanelMenu.Controls.Add(this.PanelOpciones);
            this.PanelMenu.Controls.Add(this.PanelHome);
            this.PanelMenu.Controls.Add(this.SeparadorHome);
            this.PanelMenu.Controls.Add(this.PanelInicio);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.FillColor = System.Drawing.Color.Red;
            this.PanelMenu.Location = new System.Drawing.Point(0, 30);
            this.PanelMenu.MaximumSize = new System.Drawing.Size(160, 0);
            this.PanelMenu.MinimumSize = new System.Drawing.Size(50, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(160, 420);
            this.PanelMenu.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 360);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(160, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // PanelSalida
            // 
            this.PanelSalida.Controls.Add(this.BotonSalir);
            this.PanelSalida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSalida.Location = new System.Drawing.Point(0, 370);
            this.PanelSalida.Name = "PanelSalida";
            this.PanelSalida.Padding = new System.Windows.Forms.Padding(5);
            this.PanelSalida.Size = new System.Drawing.Size(160, 50);
            this.PanelSalida.TabIndex = 4;
            // 
            // BotonSalir
            // 
            this.BotonSalir.Animated = true;
            this.BotonSalir.BorderColor = System.Drawing.Color.Red;
            this.BotonSalir.BorderRadius = 5;
            this.BotonSalir.DefaultAutoSize = true;
            this.BotonSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonSalir.FillColor = System.Drawing.Color.Maroon;
            this.BotonSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonSalir.ForeColor = System.Drawing.Color.White;
            this.BotonSalir.Image = ((System.Drawing.Image)(resources.GetObject("BotonSalir.Image")));
            this.BotonSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonSalir.Location = new System.Drawing.Point(5, 5);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(0);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.PressedColor = System.Drawing.Color.Maroon;
            this.BotonSalir.Size = new System.Drawing.Size(150, 40);
            this.BotonSalir.TabIndex = 0;
            this.BotonSalir.Tag = "Salir";
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Controls.Add(this.BotonOpciones);
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 110);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Padding = new System.Windows.Forms.Padding(5);
            this.PanelOpciones.Size = new System.Drawing.Size(160, 50);
            this.PanelOpciones.TabIndex = 3;
            // 
            // BotonOpciones
            // 
            this.BotonOpciones.Animated = true;
            this.BotonOpciones.BorderColor = System.Drawing.Color.Red;
            this.BotonOpciones.BorderRadius = 5;
            this.BotonOpciones.DefaultAutoSize = true;
            this.BotonOpciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonOpciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonOpciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonOpciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonOpciones.FillColor = System.Drawing.Color.Maroon;
            this.BotonOpciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonOpciones.ForeColor = System.Drawing.Color.White;
            this.BotonOpciones.Image = ((System.Drawing.Image)(resources.GetObject("BotonOpciones.Image")));
            this.BotonOpciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonOpciones.Location = new System.Drawing.Point(5, 5);
            this.BotonOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.BotonOpciones.Name = "BotonOpciones";
            this.BotonOpciones.PressedColor = System.Drawing.Color.Maroon;
            this.BotonOpciones.Size = new System.Drawing.Size(150, 40);
            this.BotonOpciones.TabIndex = 0;
            this.BotonOpciones.Tag = "Opciones";
            this.BotonOpciones.Text = "Opciones";
            this.BotonOpciones.Click += new System.EventHandler(this.BotonOpciones_Click);
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.BotonHome);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHome.Location = new System.Drawing.Point(0, 60);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Padding = new System.Windows.Forms.Padding(5);
            this.PanelHome.Size = new System.Drawing.Size(160, 50);
            this.PanelHome.TabIndex = 2;
            // 
            // BotonHome
            // 
            this.BotonHome.Animated = true;
            this.BotonHome.BorderColor = System.Drawing.Color.Red;
            this.BotonHome.BorderRadius = 5;
            this.BotonHome.DefaultAutoSize = true;
            this.BotonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonHome.FillColor = System.Drawing.Color.Maroon;
            this.BotonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonHome.ForeColor = System.Drawing.Color.White;
            this.BotonHome.Image = ((System.Drawing.Image)(resources.GetObject("BotonHome.Image")));
            this.BotonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonHome.Location = new System.Drawing.Point(5, 5);
            this.BotonHome.Margin = new System.Windows.Forms.Padding(0);
            this.BotonHome.Name = "BotonHome";
            this.BotonHome.PressedColor = System.Drawing.Color.Maroon;
            this.BotonHome.Size = new System.Drawing.Size(150, 40);
            this.BotonHome.TabIndex = 0;
            this.BotonHome.Tag = "Home";
            this.BotonHome.Text = "Home";
            this.BotonHome.Click += new System.EventHandler(this.BotonHome_Click);
            // 
            // SeparadorHome
            // 
            this.SeparadorHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparadorHome.Location = new System.Drawing.Point(0, 50);
            this.SeparadorHome.Name = "SeparadorHome";
            this.SeparadorHome.Size = new System.Drawing.Size(160, 10);
            this.SeparadorHome.TabIndex = 1;
            // 
            // PanelInicio
            // 
            this.PanelInicio.Controls.Add(this.BotonMenu);
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInicio.Location = new System.Drawing.Point(0, 0);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Padding = new System.Windows.Forms.Padding(5);
            this.PanelInicio.Size = new System.Drawing.Size(160, 50);
            this.PanelInicio.TabIndex = 0;
            // 
            // BotonMenu
            // 
            this.BotonMenu.Animated = true;
            this.BotonMenu.BorderColor = System.Drawing.Color.Red;
            this.BotonMenu.BorderRadius = 5;
            this.BotonMenu.DefaultAutoSize = true;
            this.BotonMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonMenu.FillColor = System.Drawing.Color.Maroon;
            this.BotonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonMenu.ForeColor = System.Drawing.Color.White;
            this.BotonMenu.Image = ((System.Drawing.Image)(resources.GetObject("BotonMenu.Image")));
            this.BotonMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonMenu.Location = new System.Drawing.Point(5, 5);
            this.BotonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BotonMenu.Name = "BotonMenu";
            this.BotonMenu.PressedColor = System.Drawing.Color.Maroon;
            this.BotonMenu.Size = new System.Drawing.Size(150, 40);
            this.BotonMenu.TabIndex = 1;
            this.BotonMenu.Tag = "Menu";
            this.BotonMenu.Text = "Menu";
            this.BotonMenu.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // AnimacionMenu
            // 
            this.AnimacionMenu.Enabled = true;
            this.AnimacionMenu.Interval = 10;
            this.AnimacionMenu.Tick += new System.EventHandler(this.AnimacionTiempo_Tick);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.Location = new System.Drawing.Point(160, 30);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 420);
            this.guna2VSeparator1.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adventure Village Estadisticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.PanelControl.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelSalida.ResumeLayout(false);
            this.PanelSalida.PerformLayout();
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox ControlCerrar;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMaximizar;
        private Guna.UI2.WinForms.Guna2Panel PanelControl;
        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel PanelHome;
        private Guna.UI2.WinForms.Guna2Button BotonHome;
        private Guna.UI2.WinForms.Guna2Separator SeparadorHome;
        private Guna.UI2.WinForms.Guna2Panel PanelInicio;
        private Guna.UI2.WinForms.Guna2Button BotonMenu;
        private System.Windows.Forms.Timer AnimacionMenu;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel PanelSalida;
        private Guna.UI2.WinForms.Guna2Button BotonSalir;
        private Guna.UI2.WinForms.Guna2Panel PanelOpciones;
        private Guna.UI2.WinForms.Guna2Button BotonOpciones;
    }
}