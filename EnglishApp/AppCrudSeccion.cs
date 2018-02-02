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
            ListaVerbosDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaVerbosDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaVerbosDataView.MultiSelect = false;
            
        }


        private void recargar(object sender, EventArgs e)
        {
            ListaVerbosDataView.DataSource = null;
            ListaVerbosDataView.DataSource = querysVerbs.Verbs();
            ListaVerbosDataView.Columns["ID"].Visible = false;
            inputInfinitive.Text = "";
            inputPast.Text = "";
            inputParticiple.Text = "";
            inputSpanish.Text = "";
            pronunciation.Text = "";
            inputPresentTense.Text = "";
            inputPastTense.Text = "";
            inputParticipleTense.Text = "";
        }

        private void btnReturnConfig_Click(object sender, EventArgs e)
        {
            EnApp app = new EnApp();
            app.Show();
            this.Hide();
        }

        private void Verbos_Load(object sender, EventArgs e)
        {
            ListaVerbosDataView.DataSource = null;
            ListaVerbosDataView.DataSource = querysVerbs.Verbs();
            ListaVerbosDataView.Columns["ID"].Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string infinitive = inputInfinitive.Text;
            string past = inputPast.Text;
            string participle = inputParticiple.Text;
            string spanish = inputSpanish.Text;
            string pronun = pronunciation.Text;
            string sentencePresent = inputPresentTense.Text;
            string sentencePast = inputPastTense.Text;
            string senteceParticipe = inputParticipleTense.Text;
            string type = Regular.Checked ? "Regular" : "Irregular";
            if (infinitive != "" && past != "" && participle != "" && spanish
                != "" && pronun != "" && sentencePresent != "" && sentencePast != "" && senteceParticipe != "")
            {

                querysVerbs.insertVerbs(infinitive, past, participle, spanish, pronun, type);
                querysVerbs.insertExample(sentencePresent, sentencePast, senteceParticipe, type);
            }
            else
            {
                Alert.Text = "COMPLETE ALL FIELDS";
            }
        }

        private void inputSearchVerb_TextChanged(object sender, EventArgs e)
        {
            ListaVerbosDataView.DataSource = null;
            ListaVerbosDataView.DataSource = querysVerbs.searchVerbs(inputSearchVerb.Text);
            ListaVerbosDataView.Columns["ID"].Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id;
            id = ListaVerbosDataView.SelectedCells[0].EditedFormattedValue.ToString();
            querysVerbs.deleteVerbs(int.Parse(id));
            querysVerbs.deleteExamples(int.Parse(id));
        }

        private void ListaVerbosDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] datos = new string[7];
            DataTable dt = new DataTable();
            for(int i=0; i<7;i++)
            {
                datos[i]= ListaVerbosDataView.SelectedCells[i].EditedFormattedValue.ToString();
            }

            dt = querysVerbs.searchExamples(datos[0]);

            inputInfinitive.Text = datos[1];
            inputPast.Text = datos[2];
            inputParticiple.Text = datos[3];
            inputSpanish.Text = datos[4];
            pronunciation.Text = datos[5];
            string tipo = datos[6];
            if (tipo == "Regular") { Regular.Checked = true; } else { Irregular.Checked = true; }
            inputPresentTense.Text = dt.Rows[0][1].ToString();
            inputPastTense.Text = dt.Rows[0][2].ToString();
            inputParticipleTense.Text = dt.Rows[0][3].ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string id= ListaVerbosDataView.SelectedCells[0].EditedFormattedValue.ToString();
            string infinitive = inputInfinitive.Text;
            string past = inputPast.Text;
            string participle = inputParticiple.Text;
            string spanish = inputSpanish.Text;
            string pronun = pronunciation.Text;
            string sentencePresent = inputPresentTense.Text;
            string sentencePast = inputPastTense.Text;
            string senteceParticipe = inputParticipleTense.Text;
            string type = Regular.Checked ? "Regular" : "Irregular";
            if (infinitive != "" && past != "" && participle != "" && spanish
                != "" && pronun != "" && sentencePresent != "" && sentencePast != "" && senteceParticipe != "")
            {
                querysVerbs.updateVerbs(infinitive, past, participle, spanish, pronun, type,int.Parse(id));
                querysVerbs.updateExamples(sentencePresent, sentencePast, senteceParticipe, type,int.Parse(id));
            }
            else
            {
                Alert.Text = "Parece que no completo todos los campos";
            }
        }
    }
}

