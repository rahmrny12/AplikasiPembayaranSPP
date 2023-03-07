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
    public partial class FormKelas : Form
    {
        private string currentID = null;

        public FormKelas()
        {
            InitializeComponent();
        }

        private void FormKelas_Load(object sender, EventArgs e)
        {
            LoadJurusan();
            LoadKelas();
            lockComponents();
        }

        private void LoadJurusan()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Jurusan", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                listKompetensiKeahlian.ValueMember = "IDJurusan";
                listKompetensiKeahlian.DisplayMember = "KompetensiKeahlian";
                listKompetensiKeahlian.DataSource = dt;
            }
        }

        private void lockComponents()
        {
            inputNamaKelas.Enabled = false;
            listKompetensiKeahlian.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockComponents()
        {
            inputNamaKelas.Enabled = true;
            listKompetensiKeahlian.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void LoadKelas()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewKelas WHERE " +
                    "NamaKelas LIKE '%" + inputSearch.Text + "%' OR " +
                    "KompetensiKeahlian LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewKelas.DataSource = dt;
                dataGridViewKelas.Columns["IDJurusan"].Visible = false;
            }
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
            try
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kelas VALUES(" +
                        "@NamaKelas, " +
                        "@IDJurusan" +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@NamaKelas", inputNamaKelas.Text);
                    cmd.Parameters.AddWithValue("@IDJurusan", listKompetensiKeahlian.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menambahkan Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKelas();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    MessageBox.Show("Kelas dengan nama tersebut sudah ada.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan Kelas. Error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kelas SET " +
                    "NamaKelas=@NamaKelas, " +
                    "IDJurusan=@IDJurusan " +
                    "WHERE IDKelas=@IDKelas", conn);
                cmd.Parameters.AddWithValue("@IDKelas", currentID);
                cmd.Parameters.AddWithValue("@NamaKelas", inputNamaKelas.Text);
                cmd.Parameters.AddWithValue("@IDJurusan", listKompetensiKeahlian.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengedit Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKelas();
            }
        }


        private bool ValidateInputs()
        {
            if (
                inputNamaKelas.Text == "" ||
                listKompetensiKeahlian.Text == ""
                )
            {
                MessageBox.Show("Lengkapi kolom yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "update";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus kelas?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = Helper.getConnected())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Kelas WHERE IDKelas='" + currentID + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil menghapus Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKelas();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Kelas sudah digunakan..!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus kelas. Pesan error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            inputNamaKelas.Text = string.Empty;
            listKompetensiKeahlian.Text = string.Empty;
        }

        private void dataGridViewKelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKelas.Rows[e.RowIndex];
                currentID = row.Cells["IDKelas"].Value.ToString();
                inputNamaKelas.Text = row.Cells["NamaKelas"].Value.ToString();
                listKompetensiKeahlian.SelectedValue = row.Cells["IDJurusan"].Value.ToString();
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadKelas();
        }
    }
}
