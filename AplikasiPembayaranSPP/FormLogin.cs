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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Petugas WHERE Username=@Username AND Password=@Password", conn);
                    cmd.Parameters.AddWithValue("@Username", inputUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", inputPass.Text);

                    SqlDataReader petugas = cmd.ExecuteReader();
                    if (petugas.Read())
                    {
                        LoggedInUser.IDPetugas = petugas["IDPetugas"].ToString();
                        LoggedInUser.NamaPetugas = petugas["NamaPetugas"].ToString();
                        LoggedInUser.Username = petugas["Username"].ToString();
                        LoggedInUser.Level = petugas["Level"].ToString();

                        FormMain formMain = new FormMain();
                        formMain.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Username atau password Anda salah...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool ValidateInputs()
        {
            if (inputUsername.Text == "" || inputPass.Text == "")
            {
                MessageBox.Show("Lengkapi kolom yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
