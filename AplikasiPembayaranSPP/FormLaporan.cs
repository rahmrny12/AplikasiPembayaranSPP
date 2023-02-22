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
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_UKK_PEMBAYARAN_SPPDataSet.ViewHistoriPembayaran' table. You can move, or remove it, as needed.
            //this.viewHistoriPembayaranTableAdapter.Fill(this.dB_UKK_PEMBAYARAN_SPPDataSet.ViewHistoriPembayaran);

            //reportViewer1.LocalReport.ReportPath = "ReportRiwayatTransaksi.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Histori", dB_UKK_PEMBAYARAN_SPPDataSet.ViewHistoriPembayaran));
            //this.reportViewer1.RefreshReport();

            using (SqlConnection conn = Helper.getConnected())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewHistoriPembayaran", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                da.Fill(this.dB_UKK_PEMBAYARAN_SPPDataSet.ViewHistoriPembayaran);

                reportViewer1.LocalReport.ReportPath = "ReportRiwayatTransaksi.rdlc";
                PageSettings settings = new System.Drawing.Printing.PageSettings();
                settings.Landscape = true;
                settings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1470);
                reportViewer1.SetPageSettings(settings);
                //reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Histori", dt));
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
