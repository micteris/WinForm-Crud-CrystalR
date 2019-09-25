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
using gasolinera.services;

namespace gasolinera
{
    public partial class MantenimientoUsuario : Form
    {
        public int? id;
        tbl_login oprovedor = null;
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            refrescar();

        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refrescar()
        {

            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                IQueryable<tbl_login> lst = from d in db.tbl_login
                                                select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        private int? getid()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {

                return null;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Resources.crud ocrud = new Resources.MantenimientoUsuario();
            agregarusuario ocrud = new agregarusuario();
            ocrud.ShowDialog();

            refrescar();

        }

        private void TxtEditar_Click(object sender, EventArgs e)
        {
            int? id = getid();
            if (id != null)
            {
                agregarusuario ofrmtabla = new agregarusuario(id);
                //Resources.crud ofrsmtabla = new Resources.crud(id);
                ofrmtabla.ShowDialog();

                refrescar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = getid();

            if (id == null)
            {
                DisplayErrorSeleccion();
                return;
            }


            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                tbl_login oproveedor = db.tbl_login.Find(id);
                db.tbl_login.Remove(oproveedor);

                db.SaveChanges();
            }
            refrescar();

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {

        }
        private void DisplayErrorSeleccion()
        {
            MessageBox.Show("Seleccione un proveedor.");
        }

        private void DisplayError()
        {
            MessageBox.Show("Ha ocurrido un error.");
        }
    }
}
