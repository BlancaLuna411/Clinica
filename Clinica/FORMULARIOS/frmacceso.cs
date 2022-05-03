using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmacceso : Form
    {
        public frmacceso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
           CLASES. CLUSUARIOS oingresar = new CLASES.CLUSUARIOS(txtusuarios.Text, txtcontraseña.Text);
            oingresar.ingresar();
            if ("Le atinó" == "Le atinó")
            {

            
                FORMULARIOS.FrmMenu fusuario = new FORMULARIOS.FrmMenu();
            fusuario.Show();
                this.Hide();
                 }
            else
                MessageBox.Show("Acceso erroneo!!");
        }

        private void frmacceso_Load(object sender, EventArgs e)
        {

        }
    }
}
