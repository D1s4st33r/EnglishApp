namespace EnglishApp
{
    partial class PanelJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelJuegos));
            this.label1 = new System.Windows.Forms.Label();
            this.MemoriLink = new System.Windows.Forms.LinkLabel();
            this.puzzle = new System.Windows.Forms.LinkLabel();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games";
            // 
            // MemoriLink
            // 
            this.MemoriLink.AutoSize = true;
            this.MemoriLink.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.MemoriLink.LinkColor = System.Drawing.Color.Goldenrod;
            this.MemoriLink.Location = new System.Drawing.Point(130, 117);
            this.MemoriLink.Name = "MemoriLink";
            this.MemoriLink.Size = new System.Drawing.Size(177, 44);
            this.MemoriLink.TabIndex = 1;
            this.MemoriLink.TabStop = true;
            this.MemoriLink.Text = "Memory";
            this.MemoriLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MemoriLink_LinkClicked);
            // 
            // puzzle
            // 
            this.puzzle.AutoSize = true;
            this.puzzle.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.puzzle.LinkColor = System.Drawing.Color.Goldenrod;
            this.puzzle.Location = new System.Drawing.Point(440, 117);
            this.puzzle.Name = "puzzle";
            this.puzzle.Size = new System.Drawing.Size(155, 44);
            this.puzzle.TabIndex = 2;
            this.puzzle.TabStop = true;
            this.puzzle.Text = "puzzle";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(12, 213);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(58, 36);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 19;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // PanelJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.puzzle);
            this.Controls.Add(this.MemoriLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel MemoriLink;
        private System.Windows.Forms.LinkLabel puzzle;
        private System.Windows.Forms.PictureBox Home;
    }
}