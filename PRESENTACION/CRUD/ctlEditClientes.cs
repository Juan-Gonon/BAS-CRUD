using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using BASE_FORM.DATOS;
using BASE_FORM.LOGICA;


namespace BASE_FORM.PRESENTACION.CRUD
{
    public partial class ctlEditClientes : UserControl
    {
        public ctlEditClientes()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Actualizar();
        }

        private void Actualizar()
        {
            DClientes funcion = new DClientes();
            Lclientes datos = new Lclientes();

            datos.idCliente = Convert.ToInt32(txtID.Text);
            datos.Nombre = txtName.Text;
            datos.Edad = Convert.ToInt32(txtEddad.Text);

            funcion.ActualizarCliente(datos);
        }

    }
}
