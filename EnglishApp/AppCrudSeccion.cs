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
    public partial class ConfigurationsVerbs : Form
    {
        public ConfigurationsVerbs()
        {//http://www.mnliteracy.org/sites/default/files
            InitializeComponent();
            ListaVerbosDataView.ColumnCount = 5;
            ListaVerbosDataView.Columns[0].Name = "#";
            ListaVerbosDataView.Columns[1].Name = "Infinitive";
            ListaVerbosDataView.Columns[2].Name = "Past";
            ListaVerbosDataView.Columns[3].Name = "Participle";
            ListaVerbosDataView.Columns[4].Name= "Spanish";
            ListaVerbosDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaVerbosDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaVerbosDataView.MultiSelect = false;
        }

        private void btnReturnConfig_Click(object sender, EventArgs e)
        {
            EnApp app = new EnApp();
            app.Show();
            this.Hide();
        }

        private void Verbos_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string inInfiniteve = inputInfinitive.Text;
            string past = inputPast.Text;
            string participle = inputParticiple.Text;
            string spanish = inputSpanish.Text;
            string sentencePresent = inputPresentTense.Text;
            string sentencePast = inputPastTense.Text;
            string senteceParticipe = inputParticipleTense.Text;
            if (inInfiniteve!="" && past != "" && participle!= "" && spanish
                !="" && sentencePresent !="" && sentencePast !="" && senteceParticipe !="")
            {
                Alert.Text = "";
            }else
            {
                Alert.Text = "Parece que no completo todos los campos";
            }
        }
    }
}

