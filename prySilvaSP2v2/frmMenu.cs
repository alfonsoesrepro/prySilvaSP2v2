using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaSP2v2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void nuevoCantanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCantante x = new frmCantante();
            x.Show();
        }

        private void nuevoTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTema x = new frmTema();
            x.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerVideo x = new frmVerVideo();
            x.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}