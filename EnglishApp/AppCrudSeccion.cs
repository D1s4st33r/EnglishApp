using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnglishApp
{


    public partial class ConfigurationsVerbs : Form
    {

        string pathDestiny = "C:/Users/maste/Desktop/EnglishApp/image/";
        string pathFinal, pathPrimary;
        int idPersistente;

        public ConfigurationsVerbs()
        {//http://www.mnliteracy.org/sites/default/files
            InitializeComponent();
            ListaVerbosDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaVerbosDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaVerbosDataView.MultiSelect = false;
            pathFinal = null;
        }


        private void recargar(object sender, EventArgs e)
        {
            ListaVerbosDataView.DataSource = null;
            ListaVerbosDataView.DataSource = querysVerbs.Verbs();
            Alert.Text = "";
            ListaVerbosDataView.Columns["ID"].Visible = false;
            inputInfinitive.Text = "";
            inputPast.Text = "";
            inputParticiple.Text = "";
            inputSpanish.Text = "";
            pronunciation.Text = "";
            inputPresentTense.Text = "";
            inputPastTense.Text = "";
            inputParticipleTense.Text = "";
            inputGerund.Text = "";
            pathFinal = null;
            imageVerb.Image = null;
            delete.Enabled = false;
            update.Enabled = false;
            add.Enabled = true;
            
        }

        private void limpiar()
        {
            ListaVerbosDataView.DataSource = null;
            ListaVerbosDataView.DataSource = querysVerbs.Verbs();
            Alert.Text = "";
            ListaVerbosDataView.Columns["ID"].Visible = false;
            inputInfinitive.Text = "";
            inputPast.Text = "";
            inputParticiple.Text = "";
            inputSpanish.Text = "";
            pronunciation.Text = "";
            inputPresentTense.Text = "";
            inputPastTense.Text = "";
            inputParticipleTense.Text = "";
            inputGerund.Text = "";
            pathFinal = null;
            imageVerb.Image = null;
            delete.Enabled = false;
            update.Enabled = false;
            add.Enabled = true;

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


        //METODO DE INSERCCION DE DATOS CON VALIDACION DE CAMPOS VACIOS
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
            string gerund = inputGerund.Text;
            string type = Regular.Checked ? "REGULAR" : "IRREGULAR";
            if (infinitive != "" && past != "" && participle != "" && spanish
                != "" && pronun != "" && sentencePresent != "" && sentencePast != "" && senteceParticipe != "" && gerund!="" && pathFinal!=null)
            {
                int validar = querysVerbs.searchData(infinitive);
                if (validar == 0)
                {
                    Alert.Text = "";
                    querysVerbs.insertVerbs(infinitive.ToUpper(), past.ToUpper(), participle.ToUpper(), spanish.ToUpper(), pronun.ToUpper(), type,gerund.ToUpper());
                    querysVerbs.insertExample(sentencePresent.ToUpper(), sentencePast.ToUpper(), senteceParticipe.ToUpper(), type);
                    System.IO.File.Copy(pathPrimary, pathFinal, true);
                    querysVerbs.insertPicture(pathFinal);
                    this.limpiar();
                } else { Alert.Text = "THIS VERB IS ALREADY IN THE DATA BASE"; }
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
            DialogResult result= MessageBox.Show("DO YOU WANT DELETE THE VERB?", "Confirmation", MessageBoxButtons.YesNoCancel);
            DataTable imageAnt = new DataTable();
            if (result == DialogResult.Yes)
            {
                imageVerb.Image = null;
                imageAnt = querysVerbs.searchPicture(idPersistente.ToString());
                querysVerbs.deleteVerbs(idPersistente);
                querysVerbs.deleteExamples(idPersistente);
                querysVerbs.deletePicture((idPersistente));
                try
                {
                    
                    System.IO.File.Delete(imageAnt.Rows[0][0].ToString());
                }
                catch (System.IO.IOException a) { MessageBox.Show(a.ToString()); }

                this.limpiar();
            }

        }

      

        private void update_Click(object sender, EventArgs e)
        {
            DataTable imageAnt = new DataTable();
            string id = idPersistente.ToString();
            imageAnt = querysVerbs.searchPicture(id);
            string infinitive = inputInfinitive.Text;
            string past = inputPast.Text;
            string participle = inputParticiple.Text;
            string spanish = inputSpanish.Text;
            string pronun = pronunciation.Text;
            string sentencePresent = inputPresentTense.Text;
            string sentencePast = inputPastTense.Text;
            string senteceParticipe = inputParticipleTense.Text;
            string type = Regular.Checked ? "REGULAR" : "IRREGULAR";
            string gerund = inputGerund.Text;
            if (infinitive != "" && past != "" && participle != "" && spanish
                != "" && pronun != "" && sentencePresent != "" && sentencePast != "" && senteceParticipe != "" && gerund!="" && pathFinal != null)
            {
                DialogResult result = MessageBox.Show("IS ABOUT TO MAKE CHANGES TO THE VERB\n DO YOU WANT TO CONTINUE?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                
                    querysVerbs.updateVerbs(infinitive.ToUpper(), past.ToUpper(), participle.ToUpper(), spanish.ToUpper(), pronun.ToUpper(), type, idPersistente,gerund.ToUpper());
                    querysVerbs.updateExamples(sentencePresent.ToUpper(), sentencePast.ToUpper(), senteceParticipe.ToUpper(), type, idPersistente);
                    
                    System.IO.File.Copy(pathPrimary, pathFinal, true);
                    querysVerbs.updatePicture(pathFinal, idPersistente);
                    try
                    {
                        
                        System.IO.File.Delete(imageAnt.Rows[0][0].ToString());
                    }
                    catch (System.IO.IOException a) { MessageBox.Show(a.ToString()); }
                }
            } else { Alert.Text = "COMPLETE ALL FIELDS"; }
        }



        private void ListaVerbosDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete.Enabled = true;
            update.Enabled = true;
            add.Enabled = false;
            DataTable image=new DataTable();
            string[] datos = new string[8];
            DataTable dt = new DataTable();
            for (int i = 0; i < 8; i++)
            {
                datos[i] = ListaVerbosDataView.SelectedCells[i].EditedFormattedValue.ToString();
            }
            idPersistente = int.Parse(datos[0]);
            dt = querysVerbs.searchExamples(datos[0]);
            image = querysVerbs.searchPicture(datos[0]);
            inputInfinitive.Text = datos[1];
            inputPast.Text = datos[2];
            inputParticiple.Text = datos[4];
            inputGerund.Text = datos[5];
            inputSpanish.Text = datos[6];
            pronunciation.Text = datos[3];
            string tipo = datos[7];
            if (tipo == "REGULAR") { Regular.Checked = true; } else { Irregular.Checked = true; }
            inputPresentTense.Text = dt.Rows[0][1].ToString();
            inputPastTense.Text = dt.Rows[0][2].ToString();
            inputParticipleTense.Text = dt.Rows[0][3].ToString();

            using (var stream = File.Open(image.Rows[0][0].ToString(), FileMode.Open))
            {
                imageVerb.Image = Image.FromStream(stream);
            }
         
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            pathPrimary= examinar.FileName;
            string nameImage = System.IO.Path.GetFileName(pathPrimary);           
            pathFinal = System.IO.Path.Combine(pathDestiny, nameImage);

            using (var stream = File.Open(pathPrimary, FileMode.Open))
            {
                imageVerb.Image = Image.FromStream(stream);
                stream.Close();
            }
        }
    }
}

