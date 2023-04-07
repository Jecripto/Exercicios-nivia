using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioNiviafinal
{
    public partial class Formloop3 : Form
    {
        public Formloop3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtresult.Clear();
            txta.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int a, result;

            a = Convert.ToInt32(txta.Text);

            for (int i = 1; i < 11; i += 1)
            {
                result = a * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
            }

        }
    }
}
