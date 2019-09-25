using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using gasolinera.model;
namespace gasolinera
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=db_gasolinera;Trusted_Connection=True;");

        public void log (string usuario, string contra)
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("Select lg_nombre from tbl_login where lg_usuario = @usuario and lg_contra = @pas", con);
                comm.Parameters.AddWithValue("usuario",usuario);
                comm.Parameters.AddWithValue("pas",contra);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count==1)
                {
                    this.Hide();
                    var principal = new principal(dt.Rows[0][0].ToString());
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o password erroneo");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pbinicio_Click(object sender, EventArgs e)
        {
            log(this.txtusuario.Text, this.txtcontra.Text);
        }

        private void Txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(((Int32)Keys.Enter)))
                Pbinicio_Click(sender, e);
        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(((Int32)Keys.Enter)))
                txtcontra.Focus();
        }
    }
}
