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
            LoadKelas();
            lockComponents();
        }

        private void lockComponents()
        {
            inputNamaKelas.Enabled = false;
            inputKompetensiKeahlian.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockComponents()
        {
            inputNamaKelas.Enabled = true;
            inputKompetensiKeahlian.Enabled = true;

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kelas WHERE " +
                    "NamaKelas LIKE '%" + inputSearch.Text + "%' OR " +
                    "KompetensiKeahlian LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewKelas.DataSource = dt;
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
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kelas VALUES(" +
                    "@NamaKelas, " +
                    "@KompetensiKeahlian" +
                    ")", conn);
                cmd.Parameters.AddWithValue("@NamaKelas", inputNamaKelas.Text);
                cmd.Parameters.AddWithValue("@KompetensiKeahlian", inputKompetensiKeahlian.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menambahkan Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKelas();
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kelas SET " +
                    "NamaKelas=@NamaKelas, " +
                    "KompetensiKeahlian=@KompetensiKeahlian " +
                    "WHERE IDKelas=@IDKelas", conn);
                cmd.Parameters.AddWithValue("@IDKelas", currentID);
                cmd.Parameters.AddWithValue("@NamaKelas", inputNamaKelas.Text);
                cmd.Parameters.AddWithValue("@KompetensiKeahlian", inputKompetensiKeahlian.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengedit Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKelas();
            }
        }


        private bool ValidateInputs()
        {
            if (
                inputNamaKelas.Text == "" ||
                inputKompetensiKeahlian.Text == ""
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
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kelas WHERE IDKelas='" + currentID + "'", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus Kelas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKelas();
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
            inputKompetensiKeahlian.Text = string.Empty;
        }

        private void dataGridViewKelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKelas.Rows[e.RowIndex];
                currentID = row.Cells["IDKelas"].Value.ToString();
                inputNamaKelas.Text = row.Cells["NamaKelas"].Value.ToString();
                inputKompetensiKeahlian.Text = row.Cells["KompetensiKeahlian"].Value.ToString();
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadKelas();
        }
    }
}
