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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.iconomenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxexit = new System.Windows.Forms.PictureBox();
            this.picboxmaximizar = new System.Windows.Forms.PictureBox();
            this.picboxminimizar = new System.Windows.Forms.PictureBox();
            this.panelcomun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconomenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomun
            // 
            this.panelcomun.BackColor = System.Drawing.Color.DimGray;
            this.panelcomun.Controls.Add(this.picboxminimizar);
            this.panelcomun.Controls.Add(this.picboxmaximizar);
            this.panelcomun.Controls.Add(this.picboxexit);
            this.panelcomun.Controls.Add(this.label1);
            this.panelcomun.Controls.Add(this.iconomenu);
            this.panelcomun.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcomun.Location = new System.Drawing.Point(0, 0);
            this.panelcomun.Name = "panelcomun";
            this.panelcomun.Size = new System.Drawing.Size(1384, 70);
            this.panelcomun.TabIndex = 0;
            // 
            // panelmenu
            // 
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 70);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(300, 791);
            this.panelmenu.TabIndex = 1;
            // 
            // panelcontent
            // 
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(300, 70);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1084, 791);
            this.panelcontent.TabIndex = 1;
            // 
            // iconomenu
            // 
            this.iconomenu.Image = ((System.Drawing.Image)(resources.GetObject("iconomenu.Image")));
            this.iconomenu.Location = new System.Drawing.Point(22, 12);
            this.iconomenu.Name = "iconomenu";
            this.iconomenu.Size = new System.Drawing.Size(45, 45);
            this.iconomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconomenu.TabIndex = 0;
            this.iconomenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIVERSIDAD DON BOSCO";
            // 
            // picboxexit
            // 
            this.picboxexit.Image = ((System.Drawing.Image)(resources.GetObject("picboxexit.Image")));
            this.picboxexit.Location = new System.Drawing.Point(1327, 12);
            this.picboxexit.Name = "picboxexit";
            this.picboxexit.Size = new System.Drawing.Size(45, 45);
            this.picboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxexit.TabIndex = 2;
            this.picboxexit.TabStop = false;
            this.picboxexit.Click += new System.EventHandler(this.picboxexit_Click);
            // 
            // picboxmaximizar
            // 
            this.picboxmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("picboxmaximizar.Image")));
            this.picboxmaximizar.Location = new System.Drawing.Point(1264, 12);
            this.picboxmaximizar.Name = "picboxmaximizar";
            this.picboxmaximizar.Size = new System.Drawing.Size(45, 45);
            this.picboxmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxmaximizar.TabIndex = 3;
            this.picboxmaximizar.TabStop = false;
            this.picboxmaximizar.Click += new System.EventHandler(this.picboxmaximizar_Click);
            // 
            // picboxminimizar
            // 
            this.picboxminimizar.Image = ((System.Drawing.Image)(resources.GetObject("picboxminimizar.Image")));
            this.picboxminimizar.Location = new System.Drawing.Point(1202, 12);
            this.picboxminimizar.Name = "picboxminimizar";
            this.picboxminimizar.Size = new System.Drawing.Size(45, 45);
            this.picboxminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxminimizar.TabIndex = 4;
            this.picboxminimizar.TabStop = false;
            this.picboxminimizar.Click += new System.EventHandler(this.picboxminimizar_Click);
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
            this.panelcomun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconomenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimizar)).EndInit();
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
    }
}

