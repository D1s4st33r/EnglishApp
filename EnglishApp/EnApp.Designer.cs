namespace EnglishApp
{
    partial class EnApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnApp));
            this.BtnVerbs = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.PictureBox();
            this.Config = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerbs
            // 
            this.BtnVerbs.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerbs.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerbs.Image")));
            this.BtnVerbs.Location = new System.Drawing.Point(42, 105);
            this.BtnVerbs.Name = "BtnVerbs";
            this.BtnVerbs.Size = new System.Drawing.Size(191, 198);
            this.BtnVerbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnVerbs.TabIndex = 0;
            this.BtnVerbs.TabStop = false;
            this.BtnVerbs.Click += new System.EventHandler(this.BtnVerbs_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.ForestGreen;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Location = new System.Drawing.Point(700, 392);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 42);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnJuegos
            // 
            this.btnJuegos.BackColor = System.Drawing.Color.Transparent;
            this.btnJuegos.Image = ((System.Drawing.Image)(resources.GetObject("btnJuegos.Image")));
            this.btnJuegos.Location = new System.Drawing.Point(560, 105);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(191, 198);
            this.btnJuegos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnJuegos.TabIndex = 3;
            this.btnJuegos.TabStop = false;
            this.btnJuegos.Click += new System.EventHandler(this.btnJuegos_Click);
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.Transparent;
            this.Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config.Image = ((System.Drawing.Image)(resources.GetObject("Config.Image")));
            this.Config.Location = new System.Drawing.Point(12, 345);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(95, 89);
            this.Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Config.TabIndex = 4;
            this.Config.TabStop = false;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // EnApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 436);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.BtnVerbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English App UPQroo";
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnVerbs;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox btnJuegos;
        private System.Windows.Forms.PictureBox Config;
    }
}

