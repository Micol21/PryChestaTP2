using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryChestaTP2
{
    public partial class Form1 : Form
    {
        ClsAccesoDatos objAccesoBD;//instaciar el objeto como una variable global
        public Form1()
        {
            objAccesoBD = new ClsAccesoDatos();//lo crea en memoria cuando se abre el formulario
            InitializeComponent();
            lblFecha.Text = (DateTime.Now).ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBD();

            lblConexion.Text = objAccesoBD.estadoConexion;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListado_de_empleados frm = new FrmListado_de_empleados();
            frm.Show();
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar frm = new FrmRegistrar();
            frm.Show();
        }
    }
}
