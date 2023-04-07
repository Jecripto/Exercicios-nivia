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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loopingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atividadePostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formposto fm = new Formposto();
            fm.Show();
        }

        private void looping1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formloop1 fm = new Formloop1();
            fm.Show();
        }

        private void looping2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formloop2 fm = new Formloop2();
            fm.Show();
        }

        private void looping3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formloop3 fm = new Formloop3();
            fm.Show();
        }
    }
}
