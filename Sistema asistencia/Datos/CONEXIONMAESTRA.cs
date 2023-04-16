using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sistema_asistencia.Logica;



namespace Sistema_asistencia.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = "Data Source=GABRIEL-FELIX; Initial Catalog=MARCALENTO;Integrated Security=true";
        public static   SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open || conectar.State == System.Data.ConnectionState.Closed)
        }
    }
}
