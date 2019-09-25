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
    public partial class Form2 : Form
    {
        public ProveedorServices proveedorService= new ProveedorServices();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            refrescar();

        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region helper
        private void refrescar()
        {
            try
            {
                var proveedores = proveedorService.GetProveedores();
                dataGridView1.DataSource = proveedores;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            //{
            //    IQueryable<tbl_proveedor> lst = from d in db.tbl_proveedor
            //              select d;
            //    dataGridView1.DataSource = lst.ToList();
            //}
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

        #endregion

        private void TxtEditar_Click(object sender, EventArgs e)
        {
            int? id = getid();
            if (id != null)
            {
                Resources.crud ofrmtabla = new Resources.crud(id);
                ofrmtabla.ShowDialog();

                refrescar();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Resources.crud ocrud = new Resources.crud();
            ocrud.ShowDialog();

            refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = getid();

            if( id == null)
            {
                DisplayErrorSeleccion();
                return;
            }


            var resp = proveedorService.DeleteProveedor(id);

            if( resp == false) {
                DisplayError();
                return;
            }
            //using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            //{
            //    tbl_proveedor oproveedor = db.tbl_proveedor.Find(id);
            //    db.tbl_proveedor.Remove(oproveedor);

            //    db.SaveChanges();
            //}
            refrescar();

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
