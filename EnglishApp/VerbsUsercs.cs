using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishApp
{
    public partial class VerbsUsercs : Form
    {
        DataTable dt = new DataTable();
        public static string type;
        public VerbsUsercs(string tipo)
        {
            InitializeComponent();
            type = tipo;
            
        }

        private void clear()
        {
            infinitive.Text = "";
            past.Text = "";
            pronun.Text = "";
            participle.Text = "";
            gerund.Text = "";
            spanish.Text = "";
            exampleInf.Text = "";
            examplePast.Text = "";
            examplePart.Text = "";
            pictureBoxVerb.Image = null;
        }

        private void VerbsUsercs_Load(object sender, EventArgs e)
        {
            Title.Text = type + " Verbs";
            listBoxofVerbs.ValueMember = "infinitive";
            listBoxofVerbs.DisplayMember = "infinitive";
            listBoxofVerbs.DataSource = querysVerbs.Infinitive(type);
        }

        private void busqueda(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(search.Text))
            {
                listBoxofVerbs.DataSource = null;
                listBoxofVerbs.DisplayMember = "infinitive";
                listBoxofVerbs.ValueMember = "infinitive";
                listBoxofVerbs.DataSource = querysVerbs.searchInf(search.Text, type);
            }
            else
            {
                listBoxofVerbs.DataSource = null;
                listBoxofVerbs.DisplayMember = "infinitive";
                listBoxofVerbs.ValueMember = "infinitive";
                listBoxofVerbs.DataSource = querysVerbs.Infinitive(type);
            }
        }

        private void showData(object sender, EventArgs e)
        {
            
            DataTable ex = new DataTable();
            
            dt = querysVerbs.verb(listBoxofVerbs.Text);

            if (dt.Rows.Count != 0)
            {
                this.clear();
                infinitive.Text = dt.Rows[0][1].ToString();
                past.Text = dt.Rows[0][2].ToString();
                pronun.Text = dt.Rows[0][3].ToString();
                participle.Text = dt.Rows[0][4].ToString();
                gerund.Text = dt.Rows[0][5].ToString();
                spanish.Text = dt.Rows[0][6].ToString();
                ex = querysVerbs.searchExamples(dt.Rows[0][0].ToString());
                exampleInf.Text = ex.Rows[0][1].ToString();
                examplePast.Text = ex.Rows[0][2].ToString();
                examplePart.Text = ex.Rows[0][3].ToString();
                ex = querysVerbs.searchPicture(dt.Rows[0][0].ToString());

                using (var stream = File.Open(ex.Rows[0][0].ToString(), FileMode.Open))
                {
                    pictureBoxVerb.Image = Image.FromStream(stream);
                }
            }
            



        }

        private void back_Click(object sender, EventArgs e)
        {
            verbsWindow menu = new verbsWindow();
            this.Hide();
            menu.Show();
        }
    }
}
