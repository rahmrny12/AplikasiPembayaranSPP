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
    public partial class FormPetugas : Form
    {
        string currentID = null;

        public FormPetugas()
        {
            InitializeComponent();
        }

        private void FormPetugas_Load(object sender, EventArgs e)
        {
            LoadPetugas();
            lockComponents();
        }

        private void lockComponents()
        {
            inputUsername.Enabled = false;
            inputPassword.Enabled = false;
            inputConfirmPass.Enabled = false;
            inputNamaPetugas.Enabled = false;
            inputLevel.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockComponents()
        {
            inputUsername.Enabled = true;
            inputPassword.Enabled = true;
            inputConfirmPass.Enabled = true;
            inputNamaPetugas.Enabled = true;
            inputLevel.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void LoadPetugas()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Petugas WHERE " +
                    "Username LIKE '%" + inputSearch.Text + "%' OR " +
                    "NamaPetugas LIKE '%" + inputSearch.Text + "%' OR " +
                    "Level LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewPetugas.DataSource = dt;
                dataGridViewPetugas.Columns["Password"].Visible = false;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Petugas VALUES(" +
                        "@Username, " +
                        "@Password, " +
                        "@NamaPetugas, " +
                        "@Level" +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@Username", inputUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", inputPassword.Text);
                    cmd.Parameters.AddWithValue("@NamaPetugas", inputNamaPetugas.Text);
                    cmd.Parameters.AddWithValue("@Level", inputLevel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menambahkan Petugas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPetugas();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    MessageBox.Show("Username tersebut sudah digunakan oleh petugas lain.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Gagal menambahkan Petugas. Error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateData()
        {
            try
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Petugas SET " +
                        "Username=@Username, " +
                        "Password=@Password, " +
                        "NamaPetugas=@NamaPetugas, " +
                        "Level=@Level " +
                        "WHERE IDPetugas=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", currentID);
                    cmd.Parameters.AddWithValue("@Username", inputUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", inputPassword.Text);
                    cmd.Parameters.AddWithValue("@NamaPetugas", inputNamaPetugas.Text);
                    cmd.Parameters.AddWithValue("@Level", inputLevel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengedit Petugas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPetugas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit Petugas. Pesan error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateInputs()
        {
            if (
                inputUsername.Text == "" ||
                inputPassword.Text == "" ||
                inputConfirmPass.Text == "" ||
                inputNamaPetugas.Text == "" ||
                inputLevel.Text == ""
                )
            {
                MessageBox.Show("Lengkapi kolom yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (inputPassword.Text != inputConfirmPass.Text)
            {
                MessageBox.Show("Konfirmasi password tidak sesuai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentID != null)
            {
                unlockComponents();
                btnSave.Tag = "update";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentID != null)
            {
                if (MessageBox.Show("Yakin ingin menghapus petugas?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = Helper.getConnected())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Petugas WHERE IDPetugas='" + currentID + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Berhasil menghapus petugas.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPetugas();
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Petugas sudah terikat transaksi..!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus petugas. Pesan error : " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            inputUsername.Text = string.Empty;
            inputPassword.Text = string.Empty;
            inputConfirmPass.Text = string.Empty;
            inputNamaPetugas.Text = string.Empty;
            inputLevel.Text = string.Empty;
        }

        private void dataGridViewPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPetugas.Rows[e.RowIndex];
                currentID = row.Cells["IDPetugas"].Value.ToString();
                inputUsername.Text = row.Cells["Username"].Value.ToString();
                inputPassword.Text = row.Cells["Password"].Value.ToString();
                inputConfirmPass.Text = row.Cells["Password"].Value.ToString();
                inputNamaPetugas.Text = row.Cells["NamaPetugas"].Value.ToString();
                inputLevel.Text = row.Cells["Level"].Value.ToString();
            }
        }

        private void dataGridViewPetugas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPetugas();
        }
    }
}
