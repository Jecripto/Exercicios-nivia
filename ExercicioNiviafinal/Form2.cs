using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioNiviafinal
{
    public partial class Formposto : Form
    {
        public Formposto()
        {
            InitializeComponent();
        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

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
            txtq.Clear();
            txtcod.Clear();
            txtresult.Clear();
            txtq.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ql, pf;
            string cod;

            ql = Convert.ToDouble(txtq.Text);
            cod = Convert.ToString(txtcod.Text);

            if (cod.Equals("A")) 
            {
                if (ql <= 20)
                {
                    pf = ql * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = pf.ToString();
                }
                else
                {
                    pf = ql * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = pf.ToString();
                }
            }
            else if (cod.Equals("G"))
            {
                if (ql > 20)
                {
                    pf = ql * (5.30 - (5.30 * 6 / 100));
                    txtresult.Text = pf.ToString();
                }
                else
                {
                    pf = ql * (5.30 - (5.30 * 4 / 100));
                    txtresult.Text = pf.ToString();
                }
            }
        }
    }
}
    
