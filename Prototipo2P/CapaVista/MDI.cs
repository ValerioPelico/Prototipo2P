using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir ab = new Abrir();
            ab.MdiParent = this;
            ab.Show();

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos ab = new Catalogos();
            ab.MdiParent = this;
            ab.Show();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos ab = new Procesos();
            ab.MdiParent = this;
            ab.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes ab = new Informes();
            ab.MdiParent = this;
            ab.Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Herramientas ab = new Herramientas();
            ab.MdiParent = this;
            ab.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ab = new Ayuda();
            ab.MdiParent = this;
            ab.Show();
        }
    }
}
