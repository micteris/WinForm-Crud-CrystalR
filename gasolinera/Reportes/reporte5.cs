using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasolinera.Reportes
{
    public partial class reporte5 : Form
    {
        public reporte5()
        {
            InitializeComponent();
        }

        private void Reporte5_Load(object sender, EventArgs e)
        {
            proveedor reporte = new proveedor();
            DataSet rp = new DataSet();

            reporte.SetDataSource(rp);
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
