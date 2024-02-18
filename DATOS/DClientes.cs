using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BASE_FORM.LOGICA;
using System.Windows.Forms; //manejar el MessageBox


namespace BASE_FORM.DATOS
{
    public class DClientes
    {
        public void InsertarClientes(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("sp_InsertarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure; //cuando hay parametros en el sp en sql
                cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Edad", parametros.Edad);

                cmd.ExecuteNonQuery(); //Ejecutar el procedimiendo de SqlComand line 19

                MessageBox.Show("Cliente Registrado");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                CONEXIONMAESTRA.cerrar();
            }
        }

     
        public void MostraClientes(ref DataTable dt) //objeto donde se insertara la data referencia a un el elemento dataTable
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("sp_MostrarCliente", CONEXIONMAESTRA.conectar);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }


        public void ActualizarCliente(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("sp_EditCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.idCliente);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@EDAD", parametros.Edad);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }

        public void EliminarCliente(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("sp_ElimitarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.idCliente);
                cmd.ExecuteNonQuery ();

                MessageBox.Show("Cliente eliminado");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar() ;
            }
        }
    }
}
