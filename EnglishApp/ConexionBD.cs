using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp
{
    class ConexionBD
    {
        public static MySqlConnection conexionBD()
        {
            string[] credentials = {"127.0.0.1","enapp" ,"root","" };// credentials server,database,user,password

            String conexionString = "Server=" + credentials[0] +
                                    ";Database=" + credentials[1] +
                                    ";User Id=" + credentials[2] +
                                    ";password=" + credentials[3];

            MySqlConnection Conexion = new MySqlConnection(conexionString);
            Conexion.Open();
            return Conexion;
        }
    }
}
