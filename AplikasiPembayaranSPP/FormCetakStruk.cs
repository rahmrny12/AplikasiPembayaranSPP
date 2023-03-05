using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormCetakStruk : Form
    {
        DataTable bayarSPP;
        string NamaPetugas;
        string NamaSiswa;
        string Kelas;
        string TotalBiaya;
        string Cash;
        string Kembalian;
        string NISN;

        public FormCetakStruk(DataTable bayarSPP,
            string namaPetugas,
            string namaSiswa,
            string nisn,
            string kelas,
            string totalBiaya,
            string cash,
            string kembalian
            )
        {
            InitializeComponent();
            this.bayarSPP = bayarSPP;
            this.NamaPetugas = namaPetugas;
            this.NamaSiswa = namaSiswa;
            this.Kelas = kelas;
            this.TotalBiaya = totalBiaya;
            this.Cash = cash;
            this.Kembalian = kembalian;
            this.NISN = nisn;
        }

        private void FormCetakStruk_Load(object sender, EventArgs e)
        {
            reportViewerStruk.LocalReport.DataSources.Add(new ReportDataSource("DataSetBayarSPP", bayarSPP));

            ReportParameter[] parameter = new ReportParameter[]
            {
                new ReportParameter("NamaPetugas", NamaPetugas),
                new ReportParameter("NamaSiswa", NamaSiswa),
                new ReportParameter("NISN", NISN),
                new ReportParameter("Kelas", Kelas),
                new ReportParameter("TotalBiaya", TotalBiaya),
                new ReportParameter("Cash", Cash),
                new ReportParameter("Kembalian", Kembalian),
            };

            reportViewerStruk.LocalReport.SetParameters(parameter);
            this.reportViewerStruk.RefreshReport();
        }
    }
}
