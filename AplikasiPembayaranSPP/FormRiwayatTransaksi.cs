using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormRiwayatTransaksi : Form
    {
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewHistoriPembayaran WHERE " +
                    "Nama LIKE '%" + inputSearch.Text + "%' OR " +
                    "NamaKelas LIKE '%" + inputSearch.Text + "%' OR " +
                    "NamaPetugas LIKE '%" + inputSearch.Text + "%' OR " +
                    "Tahun LIKE '%" + inputSearch.Text + "%' OR " +
                    "NISN LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewHistori.DataSource = dt;
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnPrintLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }
    }
}
