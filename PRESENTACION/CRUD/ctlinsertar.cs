using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BASE_FORM.DATOS;
using BASE_FORM.LOGICA;

namespace BASE_FORM.PRESENTACION.CRUD
{
    public partial class ctlinsertar : UserControl
    {
        public ctlinsertar()
        {
            InitializeComponent();
        }

        private void ctlinsertar_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void insertar()
        {
            DClientes funcion = new DClientes();
            Lclientes datos = new Lclientes();

            datos.Codigo = Convert.ToInt32(txtCodigo.Text);
            datos.Nombre = txtNombre.Text;
            datos.Edad = Convert.ToInt32(txtEdad.Text);

            funcion.InsertarClientes(datos);
        }
    }
}
