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

namespace AplikasiPembayaranSPP.Master
{
    public partial class FormSiswa : Form
    {
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            LoadSiswa();
            LoadKelas();
            LoadSPP();
            lockComponents();
        }

        private void LoadSPP()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                inputSPP.DataSource = dt;
                inputSPP.DisplayMember = "Tahun";
                inputSPP.ValueMember = "IDSPP";
            }
        }

        private void InsertMonths()
        {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand checkMonthsCmd = new SqlCommand("SELECT * FROM Pembayaran WHERE NISN='" + inputNISN.Text + "' AND TahunDibayar='" + inputSPP.Text + "'", conn);
                    SqlDataReader months = checkMonthsCmd.ExecuteReader();
                    months.Read();
                    if (!months.HasRows)
                    {
                        months.Close();
                        var newMonths = Helper.getMonths();
                        for (int i = 0; i <= newMonths.Count - 1; i++)
                        {
                            SqlCommand addMonthsCmd = new SqlCommand("INSERT INTO Pembayaran (NISN, TahunDibayar, BulanDibayar, IDSPP, JumlahBayar) VALUES(" +
                                "@NISN, " +
                                "@TahunDibayar, " +
                                "@BulanDibayar, " +
                                "@IDSPP, " +
                                "@JumlahBayar" +
                                ")", conn);
                            addMonthsCmd.Parameters.AddWithValue("NISN", inputNISN.Text);
                            addMonthsCmd.Parameters.AddWithValue("TahunDibayar", inputSPP.Text);
                            addMonthsCmd.Parameters.AddWithValue("BulanDibayar", newMonths[i]);
                            addMonthsCmd.Parameters.AddWithValue("IDSPP", inputSPP.SelectedValue);

                            DataRowView spp = inputSPP.SelectedItem as DataRowView;
                            addMonthsCmd.Parameters.AddWithValue("JumlahBayar", spp["Nominal"]);

                            addMonthsCmd.ExecuteNonQuery();
                        }
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
            }
        }

        private void lockComponents()
        {
            inputNISN.Enabled = false;
            inputNIS.Enabled = false;
            inputNama.Enabled = false;
            inputKelas.Enabled = false;
            inputAlamat.Enabled = false;
            inputNoTelp.Enabled = false;
            inputSPP.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockComponents()
        {
            inputNISN.Enabled = true;
            inputNIS.Enabled = true;
            inputNama.Enabled = true;
            inputKelas.Enabled = true;
            inputAlamat.Enabled = true;
            inputNoTelp.Enabled = true;
            inputSPP.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void LoadSiswa()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewSiswa WHERE " +
                    "NISN LIKE '%" + inputSearch.Text + "%' OR " +
                    "Nama LIKE '%" + inputSearch.Text + "%' OR " +
                    "NamaKelas LIKE '%" + inputSearch.Text + "%' OR " +
                    "Alamat LIKE '%" + inputSearch.Text + "%' OR " +
                    "NoTelp LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewSiswa.DataSource = dt;
                dataGridViewSiswa.Columns["IDKelas"].Visible = false;
                dataGridViewSiswa.Columns["IDSPP"].Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                switch (btnSave.Tag)
                {
                    case "insert":
                        InsertData();
                        break;
                    case "update":
                        UpdateData();
                        break;
                    default:
                        break;
                }
                lockComponents();
            }
        }
        private void InsertData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Siswa VALUES(" +
                        "@NISN, " +
                        "@NIS, " +
                        "@Nama, " +
                        "@IDKelas, " +
                        "@Alamat, " +
                        "@NoTelp, " +
                        "@IDSPP" +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@NISN", inputNISN.Text);
                    cmd.Parameters.AddWithValue("@NIS", inputNIS.Text);
                    cmd.Parameters.AddWithValue("@Nama", inputNama.Text);
                    cmd.Parameters.AddWithValue("@IDKelas", inputKelas.SelectedValue);
                    cmd.Parameters.AddWithValue("@Alamat", inputAlamat.Text);
                    cmd.Parameters.AddWithValue("@NoTelp", inputNoTelp.Text);
                    cmd.Parameters.AddWithValue("@IDSPP", inputSPP.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menambahkan siswa.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSiswa();
                    InsertMonths();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("NISN atau NIS tersebut sudah ada..!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan siswa. Pesan error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Siswa SET " +
                    "NISN=@NISN, " +
                    "NIS=@NIS, " +
                    "Nama=@Nama, " +
                    "IDKelas=@IDKelas, " +
                    "Alamat=@Alamat, " +
                    "NoTelp=@NoTelp, " +
                    "IDSPP=@IDSPP " +
                    "WHERE NISN=@NISN", conn);
                cmd.Parameters.AddWithValue("@NISN", inputNISN.Text);
                cmd.Parameters.AddWithValue("@NIS", inputNIS.Text);
                cmd.Parameters.AddWithValue("@Nama", inputNama.Text);
                cmd.Parameters.AddWithValue("@IDKelas", inputKelas.SelectedValue);
                cmd.Parameters.AddWithValue("@Alamat", inputAlamat.Text);
                cmd.Parameters.AddWithValue("@NoTelp", inputNoTelp.Text);
                cmd.Parameters.AddWithValue("@IDSPP", inputSPP.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengedit siswa.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSiswa();
                InsertMonths();
            }
        }


        private bool ValidateInputs()
        {
            if (
                inputNISN.Text == "" ||
                inputNIS.Text == "" ||
                inputNama.Text == "" ||
                inputKelas.Text == "" ||
                inputAlamat.Text == "" ||
                inputNoTelp.Text == "" ||
                inputSPP.Text == ""
                )
            {
                MessageBox.Show("Lengkapi kolom yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (inputNISN.Text.Length != 10)
            {
                MessageBox.Show("Kolom NISN harus 10 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (inputNIS.Text.Length != 8)
            {
                MessageBox.Show("Kolom NIS harus 8 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (inputNoTelp.Text.Length > 13 || inputNoTelp.Text.Length < 10)
            {
                MessageBox.Show("Kolom Nomor Telepon harus di antara 10 - 13 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (inputNISN.Text != "")
            {
                unlockComponents();
                inputNISN.ReadOnly = true;
                btnSave.Tag = "update";
            } else
            {
                MessageBox.Show("Klik data siswa yang ingin diedit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            inputNISN.ReadOnly = false;
            btnSave.Tag = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus siswa?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = Helper.getConnected())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Siswa WHERE NISN='" + inputNISN.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil menghapus siswa.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSiswa();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Siswa sudah melakukan pembayaran..!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus siswa. Pesan error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockComponents();
            ResetInputs();
        }

        private void ResetInputs()
        {
            inputNISN.Text = string.Empty;
            inputNIS.Text = string.Empty;
            inputNama.Text = string.Empty;
            inputKelas.Text = string.Empty;
            inputAlamat.Text = string.Empty;
            inputNoTelp.Text = string.Empty;
            inputSPP.Text = string.Empty;
        }

        private void dataGridViewSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSiswa.Rows[e.RowIndex];
                inputNISN.Text = row.Cells["NISN"].Value.ToString();
                inputNIS.Text = row.Cells["NIS"].Value.ToString();
                inputNama.Text = row.Cells["Nama"].Value.ToString();
                inputKelas.SelectedValue = row.Cells["IDKelas"].Value.ToString();
                inputAlamat.Text = row.Cells["Alamat"].Value.ToString();
                inputNoTelp.Text = row.Cells["NoTelp"].Value.ToString();
                inputSPP.SelectedValue = row.Cells["IDSPP"].Value.ToString();
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSiswa();
        }
    }
}
