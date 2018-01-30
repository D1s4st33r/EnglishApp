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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Config = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerbs
            // 
            this.BtnVerbs.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerbs.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerbs.Image")));
            this.BtnVerbs.Location = new System.Drawing.Point(63, 12);
            this.BtnVerbs.Name = "BtnVerbs";
            this.BtnVerbs.Size = new System.Drawing.Size(191, 198);
            this.BtnVerbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnVerbs.TabIndex = 0;
            this.BtnVerbs.TabStop = false;
            this.BtnVerbs.Click += new System.EventHandler(this.BtnVerbs_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Open Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(700, 382);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 42);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.Transparent;
            this.Config.Image = ((System.Drawing.Image)(resources.GetObject("Config.Image")));
            this.Config.Location = new System.Drawing.Point(12, 353);
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
            this.ClientSize = new System.Drawing.Size(802, 436);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.BtnVerbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English App UPQroo";
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnVerbs;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Config;
    }
}

