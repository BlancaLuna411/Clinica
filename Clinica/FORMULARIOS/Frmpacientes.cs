using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.FORMULARIOS
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            // CALCULAR LA EDAD 
            int año_actual = DateTime.Now.Year;
            int mes_actual = DateTime.Now.Month;
            int dia_actual = DateTime.Now.Day;
            DateTime fecha_nacimiento = Convert.ToDateTime(dtpnacimiento.Text);
            int añonacimiento = fecha_nacimiento.Year;
            int mesnacimiento = fecha_nacimiento.Month;
            int dianacimiento = fecha_nacimiento.Day;
            if (mes_actual>=mesnacimiento)
            {
                if (dia_actual >= dianacimiento)
                    txtedad.Text = (año_actual - añonacimiento).ToString();
                else
                    txtedad.Text = ((año_actual - añonacimiento) - 1).ToString();
            }
          
            else
                txtedad.Text = ((año_actual - añonacimiento)-1).ToString();


        }
    }
}
