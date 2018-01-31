using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EnglishApp
{
    class querysVerbs
    {
        //Insert Verb
        string sql = "INSERT INTO sentences(idverb, presenttense, pasttense, perfecttense) VALUES (@Infinitivo,@)";


        //METODO PARA INSERTAR NUEVOS VERBOS
        public static void insertVerbs(string infinitive, string past, string participle, string spanish, string pronunciation, string type)
        {
            string query = string.Format("INSERT INTO verbs(infinitive,past,pastParticiple,spanish,pronunciation,type) values ('{0}','{1}','{2}','{3}','{4}','{5}');", infinitive, past, participle, spanish, pronunciation, type);

            MySqlCommand comand = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("The verb has been registered!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        //METODO PARA INSERTAR NUEVOS EJEMPLOS
        public static void insertExample(string present, string past, string participle,string type)
        {
            string query = string.Format("INSERT INTO examples (simplePresent,simplePast,pastParticiple,type) values ('{0}','{1}','{2}','{3}');", present, past, participle,type);

            MySqlCommand comand = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        //METODO PARA BUSCAR VERBOS EN FORMA BASE
        public static DataTable Verbs()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT * FROM verbs;");
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //METODO PARA BUSCAR VERBOS EN FORMA BASE
        public static DataTable searchVerbs(string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT * FROM verbs WHERE infinitive LIKE ('%" + dato + "');");
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //METODO PARA BUSCAR EJEMPLOS DEL VERBO
        public static DataTable searchExamples(string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT * FROM verbs WHERE ID = '{0}';",dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ACTUALIZAR VERBOS
        public static void updateVerbs(string inifinitive, string past, string participle, string spanish, string pronunciation, string type)
        {

            string query = string.Format("UPDATE verbs SET infinitive = '{0}',past = '{1}',pastParticiple = '{2}',spanish = '{3}',pronunciation = '{4}',type = '{5}';", inifinitive, past, participle, spanish, pronunciation, type);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("DUEÑO ACTUALIZADO");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        //ACTUALIZAR EJEMPLOS
        public static void updateExamples(string present, string past, string participle, string type)
        {

            string query = string.Format("UPDATE examples SET simplePresent = '{0}',simplePast = '{1}',pastParticiple = '{2}',Type = '{3}';", present, past, participle, type);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("DUEÑO ACTUALIZADO");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

    }
}
