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
    public partial class Formloop1 : Form
    {
        public Formloop1()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtresult.Clear();
            txta.Focus();
        }

        private void Formloop1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            int i, a, result;

            a = Convert.ToInt32(txta.Text);
            i = Convert.ToInt32(txta.Text);

            i = 1;

            while (i < 11)
            {
                result = a * i;
                txtresult.Text = string.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }
        }
    }
}
