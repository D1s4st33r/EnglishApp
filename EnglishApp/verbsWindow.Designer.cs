namespace EnglishApp
{
    partial class verbsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verbsWindow));
            this.btnRegulars = new System.Windows.Forms.Button();
            this.btnIrregulars = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegulars
            // 
            this.btnRegulars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegulars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegulars.Location = new System.Drawing.Point(12, 57);
            this.btnRegulars.Name = "btnRegulars";
            this.btnRegulars.Size = new System.Drawing.Size(129, 113);
            this.btnRegulars.TabIndex = 0;
            this.btnRegulars.Text = "Regulars Verbs";
            this.btnRegulars.UseVisualStyleBackColor = false;
            this.btnRegulars.Click += new System.EventHandler(this.btnRegulars_Click);
            // 
            // btnIrregulars
            // 
            this.btnIrregulars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIrregulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrregulars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIrregulars.Location = new System.Drawing.Point(265, 57);
            this.btnIrregulars.Name = "btnIrregulars";
            this.btnIrregulars.Size = new System.Drawing.Size(129, 113);
            this.btnIrregulars.TabIndex = 1;
            this.btnIrregulars.Text = "Irregulars Verbs";
            this.btnIrregulars.UseVisualStyleBackColor = false;
            this.btnIrregulars.Click += new System.EventHandler(this.btnIrregulars_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Red;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return.Location = new System.Drawing.Point(319, 319);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 30);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // verbsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 361);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnIrregulars);
            this.Controls.Add(this.btnRegulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verbsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English App UPQRoo  - Verbs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegulars;
        private System.Windows.Forms.Button btnIrregulars;
        private System.Windows.Forms.Button Return;
    }
}