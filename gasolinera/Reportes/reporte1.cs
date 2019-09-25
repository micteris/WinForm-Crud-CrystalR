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
    public partial class reporte1 : Form
    {
        public reporte1()
        {
            InitializeComponent();
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            ventas rep = new ventas();
            DataSet rp = new DataSet();

            rep.SetDataSource(rp);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
