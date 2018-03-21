using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishApp
{
    public partial class PanelJuegos : Form
    {
        public PanelJuegos()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            EnApp app = new EnApp();
            app.Show();
            this.Hide();
        }

        private void MemoriLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemoryGame memory = new MemoryGame(11);
            memory.Show();
            this.Hide();
        }
    }
}
