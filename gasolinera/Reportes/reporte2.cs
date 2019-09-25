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
    public partial class reporte2 : Form
    {
        public reporte2()
        {
            InitializeComponent();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@codigo", "1");
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
