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
    public partial class verbsWindow : Form
    {
        public verbsWindow()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            EnApp Enapp = new EnApp();
            this.Hide();
            Enapp.Show();
        }
    }
}
