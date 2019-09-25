using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gasolinera.model;

namespace gasolinera.Resources
{
    public partial class bitacora : Form
    {

        public bitacora()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                var bitacora = db.tbl_bitacora_deta.Include("tbl_bitacora")
                    .ToList();
                var Detalle = bitacora.Select(t => new { Fecha = t.tbl_bitacora.Fecha, nombrePC = t.tbl_bitacora.nombrePC, usuario = t.tbl_bitacora.usuario, objeto = t.tbl_bitacora.objeto, accion = t.tbl_bitacora.accion, campo = t.campo, valor = t.valor }).ToList();

                dgvbit.DataSource = Detalle;
                
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgvbit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
