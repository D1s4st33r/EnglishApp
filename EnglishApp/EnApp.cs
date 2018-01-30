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
    public partial class EnApp : Form
    {
        public EnApp()
        {
            InitializeComponent();
        }

        private void BtnVerbs_Click(object sender, EventArgs e)
        {
            verbsWindow vrbWin = new verbsWindow();
            vrbWin.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Config_Click(object sender, EventArgs e)
        {
            ConfigurationsVerbs crud = new ConfigurationsVerbs();
            crud.Show();
            this.Hide();
        }
    }
}
