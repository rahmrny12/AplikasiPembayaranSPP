using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormLaporan : Form
    {
        DataTable dataLaporan;

        public FormLaporan(DataTable dt)
        {
            InitializeComponent();
            dataLaporan = dt;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataLaporan));
            reportViewer1.LocalReport.ReportPath = "ReportRiwayatTransaksi.rdlc";
            PageSettings settings = new System.Drawing.Printing.PageSettings();
            settings.Landscape = true;
            settings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1470);
            reportViewer1.SetPageSettings(settings);
            this.reportViewer1.RefreshReport();
        }
    }
}
