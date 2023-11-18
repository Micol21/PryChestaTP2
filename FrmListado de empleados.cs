using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;//para llamar al data set 
namespace PryChestaTP2
{
    public partial class FrmListado_de_empleados : Form
    {
        ClsAccesoDatos objAccesoBD;//instaciar el objeto como una variable global
        public FrmListado_de_empleados()
        {
            InitializeComponent();
            objAccesoBD = new ClsAccesoDatos();//lo crea en memoria cuando se abre el formulario
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatos(dgvEmpleados);
        }

        private void FrmListado_de_empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnFiltrarApellido_Click(object sender, EventArgs e)
        {
            objAccesoBD.Buscarempleadoporapellido(txtApellido.Text, dgvEmpleados);
            txtApellido.Clear();
        }

        private void btnFiltrarBarrio_Click(object sender, EventArgs e)
        {
            objAccesoBD.BuscarEmpleadoporciudad(txtCiudad.Text, dgvEmpleados);
            txtCiudad.Clear();
        }
    }
}
