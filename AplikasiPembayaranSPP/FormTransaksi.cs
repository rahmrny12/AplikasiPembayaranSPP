using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormTransaksi : Form
    {
        List<string> temporaryPaidMonth = new List<string>();
        List<string> alreadyPaidMonth = new List<string>();
        int nominalSPP;
        int totalBayar = 0;
        DataTable bayarSppTable = new DataTable();

        public string NISN
        {
            set { inputNISN.Text = value; }
        }

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void inputNISN_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Siswa WHERE NISN='" + inputNISN.Text + "'", conn);
                SqlDataReader siswa = cmd.ExecuteReader();
                if (siswa.Read())
                {
                    inputNama.Text = siswa["Nama"].ToString();
                    inputKelas.SelectedValue = siswa["IDKelas"].ToString();
                    inputNoTelp.Text = siswa["NoTelp"].ToString();
                    inputAlamat.Text = siswa["Alamat"].ToString();
                    inputTahun.SelectedValue = siswa["IDSPP"].ToString();
                }
                else
                {
                    inputNama.Text = string.Empty;
                    inputKelas.SelectedIndex = -1;
                    inputNoTelp.Text = string.Empty;
                    inputAlamat.Text = string.Empty;
                    ResetInputs();
                }

            }
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            inputTanggalBayar.Value = DateTime.Now;
            LoadKelas();

            bayarSppTable.Columns.Add("IDPembayaran");
            bayarSppTable.Columns.Add("TahunDibayar");
            bayarSppTable.Columns.Add("BulanDibayar");
            bayarSppTable.Columns.Add("Nominal");

            dataGridViewBayarSPP.DataSource = bayarSppTable;
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "btnRemove";
            btnRemove.HeaderText = "Remove";
            btnRemove.Text = "Remove";
            btnRemove.UseColumnTextForButtonValue = true;
            dataGridViewBayarSPP.Columns.Insert(dataGridViewBayarSPP.Columns.Count, btnRemove);
        }

        private void LoadBulan()
        {
            inputBulan.Items.Clear();

            List<string> months = Helper.getMonths();
            foreach (string month in months)
            {
                if (!alreadyPaidMonth.Contains(month) && !temporaryPaidMonth.Contains(month))
                {
                    inputBulan.Items.Add(month);
                }
            }

            if (inputBulan.Items.Count > 0)
            {
                inputBulan.SelectedIndex = 0;
            }
            else
            {
                inputBulan.Text = "";
            }
        }

        private void LoadHistoriPembayaran(string NISN)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewHistoriPembayaranPerTahun WHERE NISN='" + NISN + "' AND TahunDibayar='" + inputTahun.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewHistoriSPP.DataSource = dt;
                dataGridViewHistoriSPP.Columns["NISN"].Visible = false;
                dataGridViewHistoriSPP.Columns["IDPembayaran"].Visible = false;
                dataGridViewHistoriSPP.Columns["TglBayar"].Visible = false;

                alreadyPaidMonth.Clear();

                foreach (DataGridViewRow row in dataGridViewHistoriSPP.Rows)
                {
                    if (row.Cells["TglBayar"].Value.ToString() != "")
                    {
                        DateTime date = (DateTime)row.Cells["TglBayar"].Value;
                        row.Cells["TanggalBayar"].Value = date.ToLongDateString();

                        alreadyPaidMonth.Add(row.Cells["BulanDibayar"].Value.ToString());
                    }
                    else
                    {
                        row.Cells["TanggalBayar"].Value = "Belum Dibayar";
                    }
                }
            }
        }

        private void LoadTahunSPP()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDSPP, Tahun, Nominal FROM ViewSPPAktif WHERE NISN='" + inputNISN.Text + "' GROUP BY Tahun, IDSPP, Nominal", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                inputTahun.DisplayMember = "Tahun";
                inputTahun.ValueMember = "IDSPP";
                inputTahun.DataSource = dt;
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
                inputKelas.SelectedIndex = -1;
            }
        }

        private void inputNama_TextChanged(object sender, EventArgs e)
        {
            LoadHistoriPembayaran(inputNISN.Text);
            LoadTahunSPP();
            LoadBulan();
        }

        private void inputTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistoriPembayaran(inputNISN.Text);
            LoadBulan();
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP WHERE IDSPP='" + inputTahun.SelectedValue + "'", conn);

                SqlDataReader spp = cmd.ExecuteReader();
                if (spp.Read())
                {
                    nominalSPP = Convert.ToInt32(spp["Nominal"].ToString());
                    inputNominal.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", spp["Nominal"].ToString());
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (MessageBox.Show("Apakah detil pembayaran sudah benar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    using (SqlConnection conn = Helper.getConnected())
                    {
                        conn.Open();
                        foreach (DataGridViewRow detail in dataGridViewBayarSPP.Rows)
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Pembayaran SET " +
                                "IDPetugas=@IDPetugas, " +
                                "TglBayar=@TglBayar " +
                                "WHERE IDPembayaran=@IDPembayaran", conn);

                            cmd.Parameters.AddWithValue("@IDPembayaran", detail.Cells["IDPembayaran"].Value);
                            cmd.Parameters.AddWithValue("@IDPetugas", LoggedInUser.IDPetugas);
                            cmd.Parameters.AddWithValue("@TglBayar", inputTanggalBayar.Value);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Berhasil menambahkan transaksi.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadHistoriPembayaran(inputNISN.Text);

                        //using (PrintDialog print = new PrintDialog())
                        //{
                        //    if (print.ShowDialog() == DialogResult.OK)
                        //    {
                        //        printStruk.PrinterSettings = print.PrinterSettings;
                        //        printStruk.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1400, 800);
                        //        printStruk.DefaultPageSettings.Landscape = true;
                        //        printStruk.Print();
                        //    }
                        //}

                        CetakPembayaran(bayarSppTable);

                        ResetInputs();
                        LoadBulan();
                    }
                }
            }
        }

        private void CetakPembayaran(DataTable bayarSppTable)
        {
            FormCetakStruk formCetak = new FormCetakStruk(
                bayarSppTable,
                inputPetugas.Text,
                inputNama.Text,
                inputNISN.Text,
                inputKelas.Text,
                inputTotalBayar.Text,
                inputCash.Text,
                inputKembalian.Text
                );

            formCetak.ShowDialog();
        }

        private void ResetInputs()
        {
            bayarSppTable.Clear();
            temporaryPaidMonth.Clear();
            totalBayar = 0;
            inputTotalBayar.Text = string.Empty;
            inputCash.Value = 0;
            inputKembalian.Value = 0;
        }

        private bool ValidateInputs()
        {
            int cash = Convert.ToInt32(inputCash.Value);

            if (inputNama.Text == ""
                )
            {
                MessageBox.Show("Pilih siswa yang ingin membayar SPP!");
                return false;
            }
            else if (bayarSppTable.Rows.Count == 0)
            {
                MessageBox.Show("Pilih bulan yang ingin dibayar!");
                return false;
            }
            else if (inputCash.Value == 0)
            {
                MessageBox.Show("Lengkapi pembayaran!");
                return false;
            }
            else if (cash < totalBayar)
            {
                MessageBox.Show("Total bayar kurang!");
                return false;
            }
            return true;
        }

        private void btnSearchSiswa_Click(object sender, EventArgs e)
        {
            FormCariSiswa formCariSiswa = new FormCariSiswa(this);
            formCariSiswa.ShowDialog();
        }

        private void printStruk_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printStruk_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headingFont = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            Font bodyFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            Font importantFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);

            int currentHeight = 10;
            e.Graphics.DrawString("Aplikasi Pembayaran SPP", headingFont, Brushes.Black, 5, currentHeight);
            e.Graphics.DrawString("Petugas : " + inputPetugas.Text, bodyFont, Brushes.Black, 5, currentHeight += 70);
            e.Graphics.DrawString("Nama Siswa : " + inputNama.Text, importantFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Kelas : " + inputKelas.Text, importantFont, Brushes.Black, 5, currentHeight += 50);

            e.Graphics.DrawString("Tahun \t\t Bulan Dibayar \t Nominal \t Nama Siswa \t Kelas \t\t Keterangan", bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            foreach (DataGridViewRow item in dataGridViewBayarSPP.Rows)
            {
                e.Graphics.DrawString(item.Cells["TahunDibayar"].Value + "\t\t " + item.Cells["BulanDibayar"].Value + " \t " + item.Cells["Nominal"].Value + "\t\t " + inputNama.Text + "\t\t" + inputKelas.Text + " \t LUNAS", bodyFont, Brushes.Black, 5, currentHeight += 35);

                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 30);
            }

            e.Graphics.DrawString("Total Biaya: " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalBayar), bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Cash : " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", inputCash.Value), bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Kembalian: " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", inputKembalian.Value), bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Simpan struk ini sebagai bukti pembayaran..", importantFont, Brushes.Black, 5, currentHeight += 50);

            e.HasMorePages = false;
        }

        private void inputCash_ValueChanged(object sender, EventArgs e)
        {
            GetKembalian();
        }

        private void GetKembalian()
        {
            int kembalian = Convert.ToInt32(inputCash.Value) - totalBayar;

            if (kembalian >= 0)
            {
                inputKembalian.Value = kembalian;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DataRow detail = bayarSppTable.NewRow();
            foreach (DataGridViewRow row in dataGridViewHistoriSPP.Rows)
            {
                if (row.Cells["BulanDibayar"].Value.ToString() == inputBulan.Text)
                {
                    detail["IDPembayaran"] = row.Cells["IDPembayaran"].Value.ToString();
                }
            }
            detail["TahunDibayar"] = inputTahun.Text;
            detail["BulanDibayar"] = inputBulan.Text;
            detail["Nominal"] = nominalSPP;
            bayarSppTable.Rows.Add(detail);
            dataGridViewBayarSPP.Refresh();

            totalBayar += Convert.ToInt32(detail["Nominal"]);
            GetTotalBayar();
            temporaryPaidMonth.Add(inputBulan.Text);
            LoadBulan();
        }

        private void GetTotalBayar()
        {
            inputTotalBayar.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalBayar);
        }

        private void dataGridViewBayarSPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewBayarSPP.Columns[e.ColumnIndex].Name == "btnRemove")
                {
                    DataGridViewRow row = dataGridViewBayarSPP.Rows[e.RowIndex];
                    temporaryPaidMonth.Remove(row.Cells["BulanDibayar"].Value.ToString());
                    totalBayar -= Convert.ToInt32(row.Cells["Nominal"].Value);
                    bayarSppTable.Rows.RemoveAt(e.RowIndex);
                    LoadBulan();
                    GetTotalBayar();
                }
            }
        }
    }
}
