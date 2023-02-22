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
    public partial class FormSPP : Form
    {
        private string currentID = null;

        public FormSPP()
        {
            InitializeComponent();
        }

        private void FormSPP_Load(object sender, EventArgs e)
        {
            LoadYears();
            LoadSPP();
            lockComponents();
        }

        private void LoadYears()
        {
            int maxYear = DateTime.Now.Year;

            for (int minYear = maxYear - 5; minYear <= maxYear + 10; minYear++)
            {
                inputTahun.Items.Add(minYear);
            }
        }

        private void lockComponents()
        {
            inputNominal.Enabled = false;
            inputTahun.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockComponents()
        {
            inputNominal.Enabled = true;
            inputTahun.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void LoadSPP()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SPP WHERE " +
                    "Tahun LIKE '%" + inputSearch.Text + "%' OR " +
                    "Nominal LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewSPP.DataSource = dt;
                dataGridViewSPP.Columns["IDSPP"].Visible = false;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO SPP VALUES(" +
                        "@Tahun, " +
                        "@Nominal " +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@Tahun", inputTahun.Text);
                    cmd.Parameters.AddWithValue("@Nominal", inputNominal.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menambahkan SPP.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSPP();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    MessageBox.Show("Data SPP dengan tahun tersebut sudah ada.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data SPP. Error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SPP SET " +
                    "Tahun=@Tahun, " +
                    "Nominal=@Nominal " +
                    "WHERE IDSPP=@IDSPP", conn);
                cmd.Parameters.AddWithValue("@IDSPP", currentID);
                cmd.Parameters.AddWithValue("@Tahun", inputTahun.Text);
                cmd.Parameters.AddWithValue("@Nominal", inputNominal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengedit SPP.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSPP();
            }
        }


        private bool ValidateInputs()
        {
            if (
                inputTahun.Text == "" ||
                inputNominal.Text == ""
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
                SqlCommand cmd = new SqlCommand("DELETE FROM SPP WHERE IDSPP='" + currentID + "'", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus SPP.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSPP();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lockComponents();
            ResetInputs();
        }

        private void ResetInputs()
        {
            inputTahun.Text = string.Empty;
            inputNominal.Text = string.Empty;
        }

        private void dataGridViewSPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSPP.Rows[e.RowIndex];
                currentID = row.Cells["IDSPP"].Value.ToString();
                inputTahun.Text = row.Cells["Tahun"].Value.ToString();
                inputNominal.Text = row.Cells["Nominal"].Value.ToString();
            }
        }
    }
}
