using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_asistencia.Logica;
using System.Windows.Forms;

namespace Sistema_asistencia.Datos
{
    public class Dpersonal1
    {
        public bool InsertarPersonal(Lpersonal parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand command= new SqlCommand("InsertarPersonal",CONEXIONMAESTRA.conectar);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombres",parametros.Nombres);
                command.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                command.Parameters.AddWithValue("@Pais", parametros.Pais);
                command.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                command.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                command.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
                return false;

			}
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool editarPersonal(Lpersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand command = new SqlCommand("editaPersonal", CONEXIONMAESTRA.conectar);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                command.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                command.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                command.Parameters.AddWithValue("@Pais", parametros.Pais);
                command.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                command.Parameters.AddWithValue("@Sueldo_por_hora", parametros.SueldoPorHora);
                command.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool eliminarPersonal(Lpersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand command = new SqlCommand("eliminarPersonal", CONEXIONMAESTRA.conectar);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_personal",parametros.Id_personal);
                command.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void verPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("verPersonal",CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string Buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", Buscador);
                da.Fill(dt);




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }



    }
}
