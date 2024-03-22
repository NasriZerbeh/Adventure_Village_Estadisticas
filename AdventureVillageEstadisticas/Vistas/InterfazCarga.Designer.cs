
namespace AdventureVillageEstadisticas
{
    partial class InterfazCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazCarga));
            this.GunaBordeCargando = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelCargando = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelWait = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelRol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelBienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TerminarCarga = new System.Windows.Forms.Timer(this.components);
            this.IconoPlay = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.PanelCargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaBordeCargando
            // 
            this.GunaBordeCargando.BorderRadius = 10;
            this.GunaBordeCargando.ContainerControl = this;
            this.GunaBordeCargando.DockIndicatorTransparencyValue = 0.6D;
            this.GunaBordeCargando.ResizeForm = false;
            this.GunaBordeCargando.ShadowColor = System.Drawing.Color.White;
            this.GunaBordeCargando.TransparentWhileDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(105, 155);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(90, 90);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PanelCargando
            // 
            this.PanelCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelCargando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(49)))));
            this.PanelCargando.BorderColor = System.Drawing.Color.White;
            this.PanelCargando.BorderRadius = 10;
            this.PanelCargando.BorderThickness = 3;
            this.PanelCargando.Controls.Add(this.LabelWait);
            this.PanelCargando.Controls.Add(this.LabelNombre);
            this.PanelCargando.Controls.Add(this.LabelRol);
            this.PanelCargando.Controls.Add(this.LabelBienvenida);
            this.PanelCargando.Controls.Add(this.guna2PictureBox1);
            this.PanelCargando.Location = new System.Drawing.Point(250, 100);
            this.PanelCargando.Name = "PanelCargando";
            this.PanelCargando.Size = new System.Drawing.Size(300, 250);
            this.PanelCargando.TabIndex = 2;
            // 
            // LabelWait
            // 
            this.LabelWait.AutoSize = false;
            this.LabelWait.BackColor = System.Drawing.Color.Transparent;
            this.LabelWait.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWait.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWait.ForeColor = System.Drawing.Color.White;
            this.LabelWait.Location = new System.Drawing.Point(0, 143);
            this.LabelWait.Name = "LabelWait";
            this.LabelWait.Size = new System.Drawing.Size(300, 30);
            this.LabelWait.TabIndex = 5;
            this.LabelWait.Text = "Por favor espere un momento...\r\n";
            this.LabelWait.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = false;
            this.LabelNombre.BackColor = System.Drawing.Color.Transparent;
            this.LabelNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.ForeColor = System.Drawing.Color.White;
            this.LabelNombre.Location = new System.Drawing.Point(0, 97);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(300, 46);
            this.LabelNombre.TabIndex = 4;
            this.LabelNombre.Text = "Nombre";
            this.LabelNombre.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = false;
            this.LabelRol.BackColor = System.Drawing.Color.Transparent;
            this.LabelRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelRol.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRol.ForeColor = System.Drawing.Color.White;
            this.LabelRol.Location = new System.Drawing.Point(0, 56);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(300, 41);
            this.LabelRol.TabIndex = 3;
            this.LabelRol.Text = "Rol";
            this.LabelRol.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabelBienvenida
            // 
            this.LabelBienvenida.AutoSize = false;
            this.LabelBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.LabelBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelBienvenida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenida.ForeColor = System.Drawing.Color.White;
            this.LabelBienvenida.Location = new System.Drawing.Point(0, 0);
            this.LabelBienvenida.Name = "LabelBienvenida";
            this.LabelBienvenida.Size = new System.Drawing.Size(300, 56);
            this.LabelBienvenida.TabIndex = 2;
            this.LabelBienvenida.Text = "Bienvenido/a";
            this.LabelBienvenida.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TerminarCarga
            // 
            this.TerminarCarga.Interval = 5000;
            this.TerminarCarga.Tick += new System.EventHandler(this.TerminarCarga_Tick);
            // 
            // IconoPlay
            // 
            this.IconoPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconoPlay.BackColor = System.Drawing.Color.Transparent;
            this.IconoPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconoPlay.BackgroundImage")));
            this.IconoPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconoPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoPlay.FillColor = System.Drawing.Color.Transparent;
            this.IconoPlay.ImageRotate = 0F;
            this.IconoPlay.Location = new System.Drawing.Point(557, 201);
            this.IconoPlay.Name = "IconoPlay";
            this.IconoPlay.Size = new System.Drawing.Size(50, 50);
            this.IconoPlay.TabIndex = 3;
            this.IconoPlay.TabStop = false;
            this.IconoPlay.Visible = false;
            this.IconoPlay.Click += new System.EventHandler(this.IconoPlay_Click);
            // 
            // InterfazCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IconoPlay);
            this.Controls.Add(this.PanelCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazCarga";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.PanelCargando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm GunaBordeCargando;
        private Guna.UI2.WinForms.Guna2Panel PanelCargando;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelWait;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelRol;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelBienvenida;
        private System.Windows.Forms.Timer TerminarCarga;
        private Guna.UI2.WinForms.Guna2PictureBox IconoPlay;
    }
}