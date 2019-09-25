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
    public partial class reporte4 : Form
    {
        public reporte4()
        {
            InitializeComponent();
        }

        private void Reporte4_Load(object sender, EventArgs e)
        {
            tipo reporte = new tipo();
            reporte.SetParameterValue("@tipo", " ");
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
