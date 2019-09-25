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

namespace gasolinera
{
    public partial class agregarusuario : Form
    {
        public agregarusuario(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                cargar();
            }
                

    }

    private void RegresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int? id;
        tbl_login oprovedor = null;
       
        private void cargar()
        {
            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                oprovedor = db.tbl_login.Find(id);
                txtNombre.Text = oprovedor.lg_nombre;
                txtUsuario.Text = oprovedor.lg_usuario;
                txtContra.Text = oprovedor.lg_contra;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (db_gasolineraEntities1 db = new db_gasolineraEntities1())
            {
                if (id == null)
                    oprovedor = new tbl_login();
                oprovedor.lg_nombre= txtNombre.Text;
                oprovedor.lg_usuario = txtUsuario.Text;
                oprovedor.lg_contra = txtContra.Text;

                if (id == null)
                    db.tbl_login.Add(oprovedor);
                else
                {
                    db.Entry(oprovedor).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();

            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
