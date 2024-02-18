using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BASE_FORM.DATOS
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = "Data source=LAPTOP-3VJCNVMS; Initial Catalog=BASECURSO; User ID=code; Password=123";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if(conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
