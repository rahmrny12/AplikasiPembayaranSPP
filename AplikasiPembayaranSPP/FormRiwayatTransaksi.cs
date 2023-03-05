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
        DataTable dataHistory;
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            LoadTahunSPP();
            LoadKelas();
            LoadPetugas();
            LoadHistory();
        }

        private void LoadTahunSPP()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                inputTahun.DisplayMember = "Tahun";
                inputTahun.ValueMember = "IDSPP";
                inputTahun.DataSource = dt;
                inputTahun.Text = "";
            }
        }

        private void LoadPetugas()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Petugas", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                inputPetugas.DisplayMember = "NamaPetugas";
                inputPetugas.ValueMember = "IDPetugas";
                inputPetugas.DataSource = dt;
                if (LoggedInUser.Level != "admin")
                {
                    inputPetugas.Text = LoggedInUser.NamaPetugas;
                    inputPetugas.Enabled = false;
                } else
                {
                    inputPetugas.Text = "";
                }
            }
        }

        private void LoadKelas()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kelas", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                inputKelas.DisplayMember = "NamaKelas";
                inputKelas.ValueMember = "IDKelas";
                inputKelas.DataSource = dt;
                inputKelas.Text = "";
            }
        }

        private void LoadHistory()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewHistoriPembayaran WHERE " +
                    "(TglBayar BETWEEN '" + inputTglAwal.Value + "' AND '" + inputTglAkhir.Value + "') AND " +
                    "NamaPetugas LIKE '%" + inputPetugas.Text + "%' AND " +
                    "NamaKelas LIKE '%" + inputKelas.Text + "%' AND " +
                    "Tahun LIKE '%" + inputTahun.Text + "%' AND (" +
                    "Nama LIKE '%" + inputSearch.Text + "%' OR " +
                    "NISN LIKE '%" + inputSearch.Text + "%')", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dataHistory = new DataTable();

                da.Fill(dataHistory);
                dataGridViewHistori.DataSource = dataHistory;
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnPrintLaporan_Click(object sender, EventArgs e)
        {
            if (dataHistory.Rows.Count > 0)
            {
                FormLaporan formLaporan = new FormLaporan(dataHistory);
                formLaporan.Show();
            }
        }

        private void inputTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void inputNamaPetugas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void inputKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputTahun.Text = "";
            inputKelas.Text = "";
            if (LoggedInUser.Level == "admin")
            {
                inputPetugas.Text = "";
            }
            LoadHistory();
        }

        private void inputTglAwal_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void inputTglAkhir_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
