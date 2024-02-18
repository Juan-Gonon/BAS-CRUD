using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BASE_FORM.DATOS;
using BASE_FORM.LOGICA;

namespace BASE_FORM.PRESENTACION.CRUD
{
    public partial class ctlMostraDatos : UserControl
    {
        public ctlMostraDatos()
        {
            InitializeComponent();
        }

        int idCliente;

        private void ctlMostraDatos_Load(object sender, EventArgs e)
        {
            MostraClientes();
        }

        private void MostraClientes()
        {
            DClientes funcion = new DClientes();
            DataTable dt = new DataTable();
            funcion.MostraClientes(ref dt);
            dataList.DataSource = dt;
        }

        private void dataList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dataList.Rows.Count > 0)
            {
                idCliente = Convert.ToInt32(dataList.SelectedCells[0].Value);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Elimiar();
            MostraClientes();
        }

        private void Elimiar()
        {
            DClientes funcion = new DClientes();
            Lclientes parametros = new Lclientes();

            parametros.idCliente = idCliente;

            funcion.EliminarCliente(parametros);

        }

     
    }
}
