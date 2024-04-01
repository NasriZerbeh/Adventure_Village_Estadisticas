namespace AdventureVillageEstadisticas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.GunaBordeLogin = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelOlvidarClave = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BotonRegistrarse = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.BotonIngresarLogin = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.UsuarioTextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContraseñaTextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogoJuegoUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelControlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.ControlCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LabelLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GunaMessageBoxLogin = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoJuegoUser)).BeginInit();
            this.PanelControlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaBordeLogin
            // 
            this.GunaBordeLogin.BorderRadius = 5;
            this.GunaBordeLogin.ContainerControl = this;
            this.GunaBordeLogin.DockIndicatorTransparencyValue = 0.6D;
            this.GunaBordeLogin.ResizeForm = false;
            this.GunaBordeLogin.ShadowColor = System.Drawing.Color.White;
            this.GunaBordeLogin.TransparentWhileDrag = true;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogin.BorderColor = System.Drawing.Color.White;
            this.PanelLogin.BorderRadius = 10;
            this.PanelLogin.BorderThickness = 3;
            this.PanelLogin.Controls.Add(this.guna2HtmlLabel2);
            this.PanelLogin.Controls.Add(this.LabelOlvidarClave);
            this.PanelLogin.Controls.Add(this.BotonRegistrarse);
            this.PanelLogin.Controls.Add(this.BotonIngresarLogin);
            this.PanelLogin.Controls.Add(this.UsuarioTextBoxLogin);
            this.PanelLogin.Controls.Add(this.ContraseñaTextBoxLogin);
            this.PanelLogin.CustomBorderColor = System.Drawing.Color.White;
            this.PanelLogin.Location = new System.Drawing.Point(12, 132);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(226, 206);
            this.PanelLogin.TabIndex = 7;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(124, 181);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = null;
            // 
            // LabelOlvidarClave
            // 
            this.LabelOlvidarClave.BackColor = System.Drawing.Color.Transparent;
            this.LabelOlvidarClave.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOlvidarClave.ForeColor = System.Drawing.Color.White;
            this.LabelOlvidarClave.Location = new System.Drawing.Point(53, 181);
            this.LabelOlvidarClave.Name = "LabelOlvidarClave";
            this.LabelOlvidarClave.Size = new System.Drawing.Size(114, 22);
            this.LabelOlvidarClave.TabIndex = 7;
            this.LabelOlvidarClave.Text = "¿Olvidaste tu contraseña?";
            // 
            // BotonRegistrarse
            // 
            this.BotonRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BotonRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrarse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BotonRegistrarse.BorderRadius = 8;
            this.BotonRegistrarse.BorderThickness = 2;
            this.BotonRegistrarse.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.BotonRegistrarse.CustomImages.Image = global::AdventureVillageEstadisticas.Properties.Resources.iniciar_sesion;
            this.BotonRegistrarse.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonRegistrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonRegistrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonRegistrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonRegistrarse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonRegistrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonRegistrarse.FillColor = System.Drawing.Color.Empty;
            this.BotonRegistrarse.FillColor2 = System.Drawing.Color.Empty;
            this.BotonRegistrarse.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold);
            this.BotonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BotonRegistrarse.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.BotonRegistrarse.HoverState.BorderColor = System.Drawing.Color.White;
            this.BotonRegistrarse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BotonRegistrarse.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.BotonRegistrarse.HoverState.ForeColor = System.Drawing.Color.White;
            this.BotonRegistrarse.Location = new System.Drawing.Point(109, 147);
            this.BotonRegistrarse.Name = "BotonRegistrarse";
            this.BotonRegistrarse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotonRegistrarse.ShadowDecoration.BorderRadius = 10;
            this.BotonRegistrarse.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(226)))), ((int)(((byte)(122)))));
            this.BotonRegistrarse.ShadowDecoration.Depth = 100;
            this.BotonRegistrarse.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BotonRegistrarse.Size = new System.Drawing.Size(103, 30);
            this.BotonRegistrarse.TabIndex = 6;
            this.BotonRegistrarse.Tag = "";
            this.BotonRegistrarse.Text = "Registrarse";
            this.BotonRegistrarse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BotonRegistrarse.Click += new System.EventHandler(this.BotonRegistrarse_Click);
            // 
            // BotonIngresarLogin
            // 
            this.BotonIngresarLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BotonIngresarLogin.BackColor = System.Drawing.Color.Transparent;
            this.BotonIngresarLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BotonIngresarLogin.BorderRadius = 8;
            this.BotonIngresarLogin.BorderThickness = 2;
            this.BotonIngresarLogin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.BotonIngresarLogin.CustomImages.Image = global::AdventureVillageEstadisticas.Properties.Resources.acceso;
            this.BotonIngresarLogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BotonIngresarLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonIngresarLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonIngresarLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonIngresarLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonIngresarLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonIngresarLogin.FillColor = System.Drawing.Color.Empty;
            this.BotonIngresarLogin.FillColor2 = System.Drawing.Color.Empty;
            this.BotonIngresarLogin.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold);
            this.BotonIngresarLogin.ForeColor = System.Drawing.Color.White;
            this.BotonIngresarLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.BotonIngresarLogin.HoverState.BorderColor = System.Drawing.Color.White;
            this.BotonIngresarLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BotonIngresarLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.BotonIngresarLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.BotonIngresarLogin.Location = new System.Drawing.Point(13, 147);
            this.BotonIngresarLogin.Name = "BotonIngresarLogin";
            this.BotonIngresarLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotonIngresarLogin.ShadowDecoration.BorderRadius = 10;
            this.BotonIngresarLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(226)))), ((int)(((byte)(122)))));
            this.BotonIngresarLogin.ShadowDecoration.Depth = 100;
            this.BotonIngresarLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BotonIngresarLogin.Size = new System.Drawing.Size(90, 30);
            this.BotonIngresarLogin.TabIndex = 5;
            this.BotonIngresarLogin.Tag = "";
            this.BotonIngresarLogin.Text = "Ingresar";
            this.BotonIngresarLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BotonIngresarLogin.Click += new System.EventHandler(this.BotonIngresarLogin_Click);
            // 
            // UsuarioTextBoxLogin
            // 
            this.UsuarioTextBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UsuarioTextBoxLogin.Animated = true;
            this.UsuarioTextBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioTextBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UsuarioTextBoxLogin.BorderRadius = 10;
            this.UsuarioTextBoxLogin.BorderThickness = 2;
            this.UsuarioTextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarioTextBoxLogin.DefaultText = "";
            this.UsuarioTextBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsuarioTextBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsuarioTextBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsuarioTextBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsuarioTextBoxLogin.FillColor = System.Drawing.Color.Empty;
            this.UsuarioTextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.White;
            this.UsuarioTextBoxLogin.FocusedState.FillColor = System.Drawing.Color.Green;
            this.UsuarioTextBoxLogin.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBoxLogin.ForeColor = System.Drawing.Color.White;
            this.UsuarioTextBoxLogin.HoverState.BorderColor = System.Drawing.Color.White;
            this.UsuarioTextBoxLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UsuarioTextBoxLogin.IconLeft = global::AdventureVillageEstadisticas.Properties.Resources.usuario;
            this.UsuarioTextBoxLogin.Location = new System.Drawing.Point(33, 52);
            this.UsuarioTextBoxLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UsuarioTextBoxLogin.Name = "UsuarioTextBoxLogin";
            this.UsuarioTextBoxLogin.PasswordChar = '\0';
            this.UsuarioTextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsuarioTextBoxLogin.PlaceholderText = "Ingrese el Usuario.";
            this.UsuarioTextBoxLogin.SelectedText = "";
            this.UsuarioTextBoxLogin.ShadowDecoration.BorderRadius = 10;
            this.UsuarioTextBoxLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(226)))), ((int)(((byte)(122)))));
            this.UsuarioTextBoxLogin.ShadowDecoration.Depth = 100;
            this.UsuarioTextBoxLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.UsuarioTextBoxLogin.Size = new System.Drawing.Size(160, 40);
            this.UsuarioTextBoxLogin.TabIndex = 4;
            // 
            // ContraseñaTextBoxLogin
            // 
            this.ContraseñaTextBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContraseñaTextBoxLogin.Animated = true;
            this.ContraseñaTextBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.ContraseñaTextBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ContraseñaTextBoxLogin.BorderRadius = 10;
            this.ContraseñaTextBoxLogin.BorderThickness = 2;
            this.ContraseñaTextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContraseñaTextBoxLogin.DefaultText = "";
            this.ContraseñaTextBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContraseñaTextBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContraseñaTextBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContraseñaTextBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContraseñaTextBoxLogin.FillColor = System.Drawing.Color.Empty;
            this.ContraseñaTextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.White;
            this.ContraseñaTextBoxLogin.FocusedState.FillColor = System.Drawing.Color.Green;
            this.ContraseñaTextBoxLogin.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBoxLogin.ForeColor = System.Drawing.Color.White;
            this.ContraseñaTextBoxLogin.HoverState.BorderColor = System.Drawing.Color.White;
            this.ContraseñaTextBoxLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContraseñaTextBoxLogin.IconLeft = global::AdventureVillageEstadisticas.Properties.Resources.candado_abierto;
            this.ContraseñaTextBoxLogin.Location = new System.Drawing.Point(33, 98);
            this.ContraseñaTextBoxLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ContraseñaTextBoxLogin.Name = "ContraseñaTextBoxLogin";
            this.ContraseñaTextBoxLogin.PasswordChar = '*';
            this.ContraseñaTextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContraseñaTextBoxLogin.PlaceholderText = "Ingrese la Contraseña.";
            this.ContraseñaTextBoxLogin.SelectedText = "";
            this.ContraseñaTextBoxLogin.ShadowDecoration.BorderRadius = 10;
            this.ContraseñaTextBoxLogin.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.ContraseñaTextBoxLogin.ShadowDecoration.Depth = 100;
            this.ContraseñaTextBoxLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ContraseñaTextBoxLogin.Size = new System.Drawing.Size(160, 40);
            this.ContraseñaTextBoxLogin.TabIndex = 3;
            // 
            // LogoJuegoUser
            // 
            this.LogoJuegoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoJuegoUser.BackColor = System.Drawing.Color.Transparent;
            this.LogoJuegoUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoJuegoUser.BackgroundImage")));
            this.LogoJuegoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoJuegoUser.FillColor = System.Drawing.Color.Transparent;
            this.LogoJuegoUser.ImageRotate = 0F;
            this.LogoJuegoUser.Location = new System.Drawing.Point(44, 12);
            this.LogoJuegoUser.Name = "LogoJuegoUser";
            this.LogoJuegoUser.Size = new System.Drawing.Size(150, 150);
            this.LogoJuegoUser.TabIndex = 8;
            this.LogoJuegoUser.TabStop = false;
            // 
            // PanelControlLogin
            // 
            this.PanelControlLogin.Controls.Add(this.ControlCerrar);
            this.PanelControlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControlLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.PanelControlLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelControlLogin.Name = "PanelControlLogin";
            this.PanelControlLogin.Size = new System.Drawing.Size(250, 20);
            this.PanelControlLogin.TabIndex = 9;
            this.PanelControlLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlLogin_MouseMove);
            // 
            // ControlCerrar
            // 
            this.ControlCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlCerrar.Animated = true;
            this.ControlCerrar.BorderColor = System.Drawing.Color.White;
            this.ControlCerrar.BorderRadius = 5;
            this.ControlCerrar.BorderThickness = 1;
            this.ControlCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.ControlCerrar.IconColor = System.Drawing.Color.White;
            this.ControlCerrar.Location = new System.Drawing.Point(231, 2);
            this.ControlCerrar.Name = "ControlCerrar";
            this.ControlCerrar.Size = new System.Drawing.Size(16, 17);
            this.ControlCerrar.TabIndex = 6;
            this.ControlCerrar.Click += new System.EventHandler(this.ControlCerrar_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(84, 148);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(82, 32);
            this.LabelLogin.TabIndex = 6;
            this.LabelLogin.Text = "LOGIN";
            this.LabelLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GunaMessageBoxLogin
            // 
            this.GunaMessageBoxLogin.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.GunaMessageBoxLogin.Caption = null;
            this.GunaMessageBoxLogin.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.GunaMessageBoxLogin.Parent = this;
            this.GunaMessageBoxLogin.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.GunaMessageBoxLogin.Text = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.ControlBox = false;
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.PanelControlLogin);
            this.Controls.Add(this.LogoJuegoUser);
            this.Controls.Add(this.PanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Adventure Village";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoJuegoUser)).EndInit();
            this.PanelControlLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm GunaBordeLogin;
        private Guna.UI2.WinForms.Guna2Panel PanelControlLogin;
        private Guna.UI2.WinForms.Guna2ControlBox ControlCerrar;
        private Guna.UI2.WinForms.Guna2PictureBox LogoJuegoUser;
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private Guna.UI2.WinForms.Guna2TextBox UsuarioTextBoxLogin;
        private Guna.UI2.WinForms.Guna2TextBox ContraseñaTextBoxLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelLogin;
        private Guna.UI2.WinForms.Guna2GradientTileButton BotonIngresarLogin;
        private Guna.UI2.WinForms.Guna2MessageDialog GunaMessageBoxLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelOlvidarClave;
        private Guna.UI2.WinForms.Guna2GradientTileButton BotonRegistrarse;
    }
}