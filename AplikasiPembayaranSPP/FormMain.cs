
using AplikasiPembayaranSPP.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembayaranSPP
{
    public partial class FormMain : Form
    {
        private Control activeForm = null;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                LoggedInUser.DestroySession();
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show(); 
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.Level == "petugas")
            {
                navSiswa.Visible = false;
                navKelas.Visible = false;
                navSPP.Visible = false;
                navPetugas.Visible = false;
            }
            labelName.Text = LoggedInUser.NamaPetugas;
            labelLevel.Text = LoggedInUser.Level;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void navSiswa_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            FormSiswa formSiswa = new FormSiswa();
            activeForm = formSiswa;
            formSiswa.TopLevel = false;
            formSiswa.Dock = DockStyle.Fill;
            formSiswa.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formSiswa);
            labelFormTitle.Text = "Data Siswa";
            formSiswa.Show();
        }

        private void navPetugas_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            labelFormTitle.Text = "Data Petugas";
            FormPetugas formPetugas = new FormPetugas();
            activeForm = formPetugas;
            formPetugas.TopLevel = false;
            formPetugas.Dock = DockStyle.Fill;
            formPetugas.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formPetugas);
            formPetugas.Show();
        }

        private void navKelas_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            labelFormTitle.Text = "Data Kelas";
            FormKelas formKelas = new FormKelas();
            activeForm = formKelas;
            formKelas.TopLevel = false;
            formKelas.Dock = DockStyle.Fill;
            formKelas.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formKelas);
            formKelas.Show();
        }

        private void navSPP_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            labelFormTitle.Text = "Data SPP";
            FormSPP formSPP = new FormSPP();
            activeForm = formSPP;
            formSPP.TopLevel = false;
            formSPP.Dock = DockStyle.Fill;
            formSPP.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formSPP);
            formSPP.Show();
        }

        private void navTransaksi_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            labelFormTitle.Text = "Transaksi Baru";
            FormTransaksi formTransaksi = new FormTransaksi();
            activeForm = formTransaksi;
            formTransaksi.TopLevel = false;
            formTransaksi.Dock = DockStyle.Fill;
            formTransaksi.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formTransaksi);
            formTransaksi.Show();
        }

        private void navHistori_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                panelForm.Controls.Remove(activeForm);
            }

            labelFormTitle.Text = "Histori Transaksi";
            FormRiwayatTransaksi formRiwayatTransaksi = new FormRiwayatTransaksi();
            activeForm = formRiwayatTransaksi;
            formRiwayatTransaksi.TopLevel = false;
            formRiwayatTransaksi.Dock = DockStyle.Fill;
            formRiwayatTransaksi.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(formRiwayatTransaksi);
            formRiwayatTransaksi.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
