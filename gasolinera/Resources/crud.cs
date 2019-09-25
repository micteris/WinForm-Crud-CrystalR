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
    public partial class crud : Form
    {
        public int? id;
        tbl_proveedor oprovedor = null;
        public crud(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id!=null)
            {
                cargar();
            }
        }

        private void cargar()
        {
            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                oprovedor = db.tbl_proveedor.Find(id);
                txtNombre.Text = oprovedor.prv_nombre;
                txtCentral.Text = oprovedor.prv_CentralA;
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (db_gasolineraEntities1 db= new db_gasolineraEntities1())
            {
                if (id==null)
                    oprovedor = new tbl_proveedor();
                oprovedor.prv_nombre = txtNombre.Text;
                oprovedor.prv_CentralA = txtCentral.Text;

                if(id==null)
                    db.tbl_proveedor.Add(oprovedor);
                else
                {
                    db.Entry(oprovedor).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();

            }
        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }
    }
}
