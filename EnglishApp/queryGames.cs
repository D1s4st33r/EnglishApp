using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishApp
{
    class queryGames
    {
        public static int[] GetFirstLastID()
        {
            MySqlConnection conexion = new MySqlConnection();
            int[] limites = new[]{ 0,0};
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT MIN(ID) ,MAX(ID) FROM verbs;");
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader.GetString(0),out limites[0]);
                Int32.TryParse(reader.GetString(1), out limites[1]);
            }
            return limites;
        }

        public static string[] RandomVerbsImage(int  level)
        {
            int[] limites = queryGames.GetFirstLastID(), numerosLista= new int[level];
            Random rnd = new Random();
            int i = 0 , random;
            string[] nommbreimg = new string[level];
            do {
                random = rnd.Next(limites[0], limites[1] + 1);
                if (queryGames.existe(numerosLista , random))
                {
                    numerosLista[i] = random;
                    nommbreimg[i] = queryGames.nombreImagebyID(random);
                    i++;
                }

            } while (level != i);

            return nommbreimg;
        }
        public static bool existe(int[] array , int numero) 
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (numero == array[j])
                {
                    return false;
                }
            }
            return true;
        }
        public static string nombreImagebyID(int id)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT imagen FROM verbs where ID ={0};",id);
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            string nombre="";
            while (reader.Read())
            {
                nombre = reader.GetString(0);
            }
            return nombre;
        }

        public static int Verbs()
        {
           int pivote=0;
            MySqlConnection conexion = new MySqlConnection();
            conexion = ConexionBD.conexionBD();
            string query = string.Format("SELECT COUNT(ID) FROM verbs;");
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 Int32.TryParse(reader.GetString(0),out pivote);
            }
            return pivote;
        }
    }
}
