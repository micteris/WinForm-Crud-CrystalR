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
    public partial class reporte3 : Form
    {
        public reporte3()
        {
            InitializeComponent();
        }

        private void Reporte3_Load(object sender, EventArgs e)
        {
            //bombas reporte = new bombas();
            //reporte.SetParameterValue("@nombre","Uno Kuwait");
            //reporte.SetParameterValue("@codigo",1);
            //reporte.SetParameterValue("@tipo","Super");
            //reporte.SetParameterValue("@estado","F");
            //reporte.SetParameterValue("@litros","15.83 litros");
            //reporte.SetParameterValue("@total",400);
            //crystalReportViewer1.ReportSource = reporte;
            bombas rep = new bombas();
            DataSet rp = new DataSet();

            rep.SetDataSource(rp);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
