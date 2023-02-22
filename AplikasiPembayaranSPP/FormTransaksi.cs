using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormTransaksi : Form
    {
        List<string> alreadyPaidMonth = new List<string>();
        int nominal;
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

                    InsertMonths();
                }
                else
                {
                    inputNama.Text = string.Empty;
                    inputKelas.SelectedIndex = -1;
                    inputNoTelp.Text = string.Empty;
                    inputAlamat.Text = string.Empty;
                }

            }
        }

        private void InsertMonths()
        {
            if (inputNama.Text != "" && inputTahun.Text != "")
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand checkMonthsCmd = new SqlCommand("SELECT * FROM Pembayaran WHERE NISN='" + inputNISN.Text + "' AND TahunDibayar='" + inputTahun.Text + "'", conn);
                    SqlDataReader months = checkMonthsCmd.ExecuteReader();
                    months.Read();
                    if (!months.HasRows)
                    {
                        months.Close();
                        DateTimeFormatInfo format = new DateTimeFormatInfo();
                        for (int i = 1; i <= 12; i++)
                        {
                            string month = format.GetMonthName(i);
                            SqlCommand addMonthsCmd = new SqlCommand("INSERT INTO Pembayaran (NISN, TahunDibayar, BulanDibayar, IDSPP, JumlahBayar) VALUES(" +
                                "@NISN, " +
                                "@TahunDibayar, " +
                                "@BulanDibayar, " +
                                "@IDSPP, " +
                                "@JumlahBayar" +
                                ")", conn);
                            addMonthsCmd.Parameters.AddWithValue("NISN", inputNISN.Text);
                            addMonthsCmd.Parameters.AddWithValue("TahunDibayar", inputTahun.Text);
                            addMonthsCmd.Parameters.AddWithValue("BulanDibayar", month);
                            addMonthsCmd.Parameters.AddWithValue("IDSPP", inputTahun.SelectedValue);
                            addMonthsCmd.Parameters.AddWithValue("JumlahBayar", nominal);

                            addMonthsCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            inputTanggalBayar.Value = DateTime.Now;
            LoadTahunSPP();
            LoadKelas();
            dataGridViewBayarSPP.DataSource = bayarSppTable;
        }

        private void LoadBulan()
        {
            //DateTime startMonth = new DateTime();
            DateTimeFormatInfo format = new DateTimeFormatInfo();
            inputBulan.Items.Clear();
            for (int i = 1; i < 12; i++)
            {
                string month = format.GetMonthName(i);
                if (!alreadyPaidMonth.Contains(month))
                {
                    inputBulan.Items.Add(month);
                }
            }
            if (inputBulan.Items.Count > 0)
            {
                inputBulan.SelectedIndex = 0;
            } else
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
                        DateTime date = (DateTime) row.Cells["TglBayar"].Value;
                        row.Cells["TanggalBayar"].Value = date.ToLongDateString();
                        alreadyPaidMonth.Add(row.Cells["BulanDibayar"].Value.ToString());
                    } else
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP", conn);
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
            LoadBulan();
        }

        private void inputTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertMonths();
            LoadHistoriPembayaran(inputNISN.Text);
            LoadBulan();
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP WHERE IDSPP='" + inputTahun.SelectedValue + "'", conn);

                SqlDataReader spp = cmd.ExecuteReader();
                if (spp.Read())
                {
                    nominal = Convert.ToInt32(spp["Nominal"].ToString());
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
                        SqlCommand cmd = new SqlCommand("UPDATE Pembayaran SET " +
                            "IDPetugas=@IDPetugas, " +
                            "TglBayar=@TglBayar " +
                            "WHERE IDPembayaran=@IDPembayaran", conn);

                        foreach (DataGridViewRow row in dataGridViewHistoriSPP.Rows)
                        {
                            if (row.Cells["BulanDibayar"].Value.ToString() == inputBulan.Text)
                            {
                                cmd.Parameters.AddWithValue("@IDPembayaran", row.Cells["IDPembayaran"].Value.ToString());
                            }
                        }
                        cmd.Parameters.AddWithValue("@IDPetugas", LoggedInUser.IDPetugas);
                        cmd.Parameters.AddWithValue("@TglBayar", inputTanggalBayar.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil menambahkan transaksi.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (PrintDialog print = new PrintDialog())
                        {
                            if (print.ShowDialog() == DialogResult.OK)
                            {
                                printStruk.PrinterSettings = print.PrinterSettings;
                                printStruk.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1400, 800);
                                printStruk.DefaultPageSettings.Landscape = true;
                                printStruk.Print();
                            }
                        }

                        LoadHistoriPembayaran(inputNISN.Text);
                        LoadBulan();
                    }
                }
            }
        }

        private bool ValidateInputs()
        {
            int totalBayar = Convert.ToInt32(inputTotalBayar.Value);

            if (inputNISN.Text == ""
                )
            {
                MessageBox.Show("Pilih siswa yang ingin membayar SPP!");
                return false;
            }
            else if (inputBulan.Text == "")
            {
                MessageBox.Show("Pilih bulan yang ingin dibayar!");
                return false;
            } else if (inputTotalBayar.Value == 0)
            {
                MessageBox.Show("Lengkapi pembayaran!");
                return false;
            } else if (totalBayar < nominal )
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
            e.Graphics.DrawString("Petugas : " + inputPetugas.Text, importantFont, Brushes.Black, 5, currentHeight += 70);

            e.Graphics.DrawString("Tahun \t\t Bulan Dibayar \t Nominal \t Nama Siswa \t Kelas \t\t Keterangan", bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            e.Graphics.DrawString(inputTahun.Text + "\t\t " + inputBulan.Text + " \t\t " + inputNominal.Text + "\t " + inputNama.Text + "\t" + inputKelas.Text + " \t LUNAS", bodyFont, Brushes.Black, 5, currentHeight += 35);

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 30);

            e.Graphics.DrawString("Total Biaya: " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", inputTotalBayar.Value), bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Kembalian: " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", inputKembalian.Value), bodyFont, Brushes.Black, 5, currentHeight += 50);
            e.Graphics.DrawString("Simpan struk ini sebagai bukti pembayaran..", importantFont, Brushes.Black, 5, currentHeight += 50);

            e.HasMorePages = false;
        }

        private void inputTotalBayar_ValueChanged(object sender, EventArgs e)
        {

            GetKembalian();
        }

        private void GetKembalian()
        {
            int kembalian = Convert.ToInt32(inputTotalBayar.Value) - nominal;

            if (kembalian >= 0)
            {
                inputKembalian.Value = kembalian;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DataRow bayar = bayarSppTable.NewRow();
        }
    }
}
