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
    public partial class Formloop2 : Form
    {
        public Formloop2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtresult.Clear();
            txta.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int valor, i, result;

            valor = Convert.ToInt32(txta.Text);
            i = Convert.ToInt32(txta.Text);

            i = 1;

            do
            {
                result = valor * 1;

                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            } while (i < 11);
        }
    }
}
