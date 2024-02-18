using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BASE_FORM.PRESENTACION.CRUD
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void Insertar()
        {
            pnlVisor.Controls.Clear();
            ctlinsertar ctl = new ctlinsertar();
            ctl.Dock = DockStyle.Fill;
            pnlVisor.Controls.Add(ctl);
            ctl.Show();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pnlVisor.Controls.Clear();
            ctlMostraDatos ctl = new ctlMostraDatos();
            ctl.Dock = DockStyle.Fill;
            pnlVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizr();
        }
        private void Actualizr()
        {
            pnlVisor.Controls.Clear();
            ctlEditClientes ctl = new ctlEditClientes();
            ctl.Dock = DockStyle.Fill;
            pnlVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
