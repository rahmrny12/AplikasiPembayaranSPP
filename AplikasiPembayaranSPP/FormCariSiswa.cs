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
    public partial class FormCariSiswa : Form
    {
        private FormTransaksi formTransaksi;

        public FormCariSiswa(FormTransaksi formTransaksi)
        {
            InitializeComponent();
            this.formTransaksi = formTransaksi;
        }

        private void inputNISN_TextChanged(object sender, EventArgs e)
        {
            LoadSiswa();
        }

        private void LoadSiswa()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewSiswa WHERE Nama LIKE '%" + inputSearch.Text + "%' OR NamaKelas LIKE '%" + inputSearch.Text + "%' OR NISN LIKE '%" + inputSearch.Text + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridViewSiswa.DataSource = dt;
            }
            
        }

        private void dataGridViewSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewSiswa.Columns[e.ColumnIndex].Name == "Choose")
                {
                    formTransaksi.NISN = dataGridViewSiswa.Rows[e.RowIndex].Cells["NISN"].Value.ToString();
                    this.Close();
                }
            }
        }

        private void FormCariSiswa_Load(object sender, EventArgs e)
        {
            LoadSiswa();
            DataGridViewButtonColumn btnChoose = new DataGridViewButtonColumn();
            btnChoose.Name = "Choose";
            btnChoose.Text = "Choose";
            btnChoose.UseColumnTextForButtonValue = true;
            dataGridViewSiswa.Columns.Insert(0, btnChoose);
            dataGridViewSiswa.Columns["Nama"].DisplayIndex = 1;
        }

        private void dataGridViewSiswa_DoubleClick(object sender, EventArgs e)
        {
            formTransaksi.NISN = dataGridViewSiswa.CurrentRow.Cells["NISN"].Value.ToString();
            this.Close();
        }
    }
}
