namespace ProyectCatedra_PEDT_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelcomun = new System.Windows.Forms.Panel();
            this.picboxminimizar = new System.Windows.Forms.PictureBox();
            this.picboxmaximizar = new System.Windows.Forms.PictureBox();
            this.picboxexit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconomenu = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.picrestaurar = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lineaseparador = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panelcomun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomenu)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picrestaurar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcomun
            // 
            this.panelcomun.BackColor = System.Drawing.Color.Black;
            this.panelcomun.Controls.Add(this.picrestaurar);
            this.panelcomun.Controls.Add(this.picboxminimizar);
            this.panelcomun.Controls.Add(this.picboxmaximizar);
            this.panelcomun.Controls.Add(this.picboxexit);
            this.panelcomun.Controls.Add(this.iconomenu);
            this.panelcomun.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcomun.Location = new System.Drawing.Point(0, 0);
            this.panelcomun.Name = "panelcomun";
            this.panelcomun.Size = new System.Drawing.Size(1384, 64);
            this.panelcomun.TabIndex = 0;
            // 
            // picboxminimizar
            // 
            this.picboxminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxminimizar.Image = ((System.Drawing.Image)(resources.GetObject("picboxminimizar.Image")));
            this.picboxminimizar.Location = new System.Drawing.Point(1230, 17);
            this.picboxminimizar.Name = "picboxminimizar";
            this.picboxminimizar.Size = new System.Drawing.Size(30, 30);
            this.picboxminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxminimizar.TabIndex = 4;
            this.picboxminimizar.TabStop = false;
            this.picboxminimizar.Click += new System.EventHandler(this.picboxminimizar_Click);
            // 
            // picboxmaximizar
            // 
            this.picboxmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("picboxmaximizar.Image")));
            this.picboxmaximizar.Location = new System.Drawing.Point(1283, 17);
            this.picboxmaximizar.Name = "picboxmaximizar";
            this.picboxmaximizar.Size = new System.Drawing.Size(30, 30);
            this.picboxmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxmaximizar.TabIndex = 3;
            this.picboxmaximizar.TabStop = false;
            this.picboxmaximizar.Click += new System.EventHandler(this.picboxmaximizar_Click);
            // 
            // picboxexit
            // 
            this.picboxexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxexit.Image = ((System.Drawing.Image)(resources.GetObject("picboxexit.Image")));
            this.picboxexit.Location = new System.Drawing.Point(1333, 17);
            this.picboxexit.Name = "picboxexit";
            this.picboxexit.Size = new System.Drawing.Size(30, 30);
            this.picboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxexit.TabIndex = 2;
            this.picboxexit.TabStop = false;
            this.picboxexit.Click += new System.EventHandler(this.picboxexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIVERSIDAD DON BOSCO";
            // 
            // iconomenu
            // 
            this.iconomenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconomenu.Image = ((System.Drawing.Image)(resources.GetObject("iconomenu.Image")));
            this.iconomenu.Location = new System.Drawing.Point(23, 17);
            this.iconomenu.Name = "iconomenu";
            this.iconomenu.Size = new System.Drawing.Size(30, 30);
            this.iconomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconomenu.TabIndex = 0;
            this.iconomenu.TabStop = false;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Black;
            this.panelmenu.Controls.Add(this.bunifuGradientPanel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 64);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(300, 797);
            this.panelmenu.TabIndex = 1;
            // 
            // panelcontent
            // 
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(300, 64);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1084, 797);
            this.panelcontent.TabIndex = 1;
            // 
            // picrestaurar
            // 
            this.picrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picrestaurar.Image")));
            this.picrestaurar.Location = new System.Drawing.Point(1283, 17);
            this.picrestaurar.Name = "picrestaurar";
            this.picrestaurar.Size = new System.Drawing.Size(30, 30);
            this.picrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrestaurar.TabIndex = 5;
            this.picrestaurar.TabStop = false;
            this.picrestaurar.Visible = false;
            this.picrestaurar.Click += new System.EventHandler(this.picrestaurar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lineaseparador);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 17);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(270, 768);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lineaseparador
            // 
            this.lineaseparador.BackColor = System.Drawing.Color.Transparent;
            this.lineaseparador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineaseparador.BackgroundImage")));
            this.lineaseparador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineaseparador.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.lineaseparador.LineColor = System.Drawing.Color.White;
            this.lineaseparador.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.lineaseparador.LineThickness = 1;
            this.lineaseparador.Location = new System.Drawing.Point(11, 35);
            this.lineaseparador.Name = "lineaseparador";
            this.lineaseparador.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.lineaseparador.Size = new System.Drawing.Size(252, 40);
            this.lineaseparador.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcomun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelcomun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomenu)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picrestaurar)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcomun;
        private System.Windows.Forms.PictureBox iconomenu;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxminimizar;
        private System.Windows.Forms.PictureBox picboxmaximizar;
        private System.Windows.Forms.PictureBox picboxexit;
        private System.Windows.Forms.PictureBox picrestaurar;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuSeparator lineaseparador;
    }
}

