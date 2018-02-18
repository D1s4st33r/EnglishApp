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


        //METODO PARA INSERTAR NUEVOS VERBOS
        public static void insertVerbs(string infinitive, string past, string participle, string spanish, string pronunciation, string type,string gerund)
        {
            string query = string.Format("INSERT INTO verbs(infinitive,past,pronunciation,pastParticiple,gerund,spanish,type) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", infinitive, past, pronunciation, participle, gerund, spanish, type);

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


        //METODO PARA INSERTAR NUEVOS LA FOTO DE EL VERBO
        public static void insertPicture(string path)
        {
            string query = string.Format("INSERT INTO pictureVerbs (path) values (@ruta);");
            
            MySqlCommand comand = new MySqlCommand(query, ConexionBD.conexionBD());
            comand.Parameters.AddWithValue("@ruta", path);
            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("THE VERB HASE BEEN REGISTERED SUCCESSFULLY");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        //METODO PARA BUSCAR TODOS LOS VERBOS
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
            string query = string.Format("SELECT * FROM verbs WHERE infinitive LIKE ('%" + dato + "%');");
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
            string query = string.Format("SELECT * FROM examples WHERE ID = '{0}';",dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //METODO PARA BUSCAR LA IMAGEN DEL VERBO
        public static DataTable searchPicture(string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT path FROM pictureVerbs WHERE ID = '{0}';", dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //METODO PARA BUSQUEDA INDIVIDUAL DE DATO
        public static int searchData(string dato)
        {
            string query = string.Format("SELECT count(infinitive) from verbs WHERE infinitive ='{0}';", dato);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            int respuesta = 0;
            respuesta= (Convert.ToInt32(comando.ExecuteScalar()));
            return respuesta;
        }

        //METODO PARA CONTEO DE DATOS
        public static int searchCount()
        {
            string query = string.Format("SELECT count(infinitive) from verbs;");
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            int respuesta = 0;
            respuesta = (Convert.ToInt32(comando.ExecuteScalar()));
            return respuesta;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ACTUALIZAR VERBOS
        public static void updateVerbs(string infinitive, string past, string participle, string spanish, string pronunciation, string type,int id, string gerund)
        {

            string query = string.Format("UPDATE verbs SET infinitive = '{0}',past = '{1}',pastParticiple = '{2}',spanish = '{3}',gerund='{7}',pronunciation = '{4}',type = '{5}' WHERE ID='{6}';", infinitive, past, participle, spanish, pronunciation, type,id,gerund);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comando.ExecuteNonQuery();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        //ACTUALIZAR EJEMPLOS
        public static void updateExamples(string present, string past, string participle, string type, int id)
        {

            string query = string.Format("UPDATE examples SET simplePresent = '{0}',simplePast = '{1}',pastParticiple = '{2}',Type = '{3}' WHERE ID='{4}';", present, past, participle, type,id);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        //ACTUALIZAR FOTO
        public static void updatePicture(string path, int id)
        {

            string query = string.Format("UPDATE pictureVerbs SET path = '{0}' WHERE ID='{1}';",path,id);
            query = query.Replace(@"\", "\\");
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("THE VERB AND EXAMPLES HAVE BEEN UPDATE");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////


        public static void deleteVerbs(int id)
        {
            string query = string.Format("DELETE FROM verbs WHERE ID='{0}'",id);
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

        public static void deleteExamples(int id)
        {
            string query = string.Format("DELETE FROM examples WHERE ID='{0}'", id);
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


        public static void deletePicture(int id)
        {
            string query = string.Format("DELETE FROM pictureVerbs WHERE ID='{0}'", id);
            MySqlCommand comand = new MySqlCommand(query, ConexionBD.conexionBD());
            try
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("THE VERB AND EXAMPLES HAVE BEEN ELIMINATED");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
