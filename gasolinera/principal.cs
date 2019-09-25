using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasolinera
{
    public partial class principal : Form
    {
        public principal(string nombre)
        {
            InitializeComponent();
            lblidentificador.Text = nombre;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmant = new Form2();
            frmant.Show();
        }

        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resources.bitacora bt = new Resources.bitacora();
            bt.ShowDialog();
        }

        private void ReporteventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.reporte1 rp1 = new Reportes.reporte1();
            rp1.ShowDialog();
        }

        private void ReporteempleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.reporte2 rp2 = new Reportes.reporte2();
            rp2.ShowDialog();
        }

        private void ReportebombasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.reporte3 rp3 = new Reportes.reporte3();
            rp3.ShowDialog();
        }

        private void ReportetipodebombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.reporte4 rp4 = new Reportes.reporte4();
            rp4.ShowDialog();
        }

        private void ReporteProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.reporte5 rp5 = new Reportes.reporte5();
            rp5.ShowDialog();
        }

        private void MantenimientoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario mus = new MantenimientoUsuario();
            mus.ShowDialog();
        }
    }
}
