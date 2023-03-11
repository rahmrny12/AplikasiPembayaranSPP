namespace AplikasiPembayaranSPP
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputTotalBayar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.inputKembalian = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.inputCash = new System.Windows.Forms.NumericUpDown();
            this.inputTanggalBayar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPetugas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.inputBulan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputNominal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTahun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchSiswa = new System.Windows.Forms.Button();
            this.inputKelas = new System.Windows.Forms.ComboBox();
            this.inputAlamat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputNoTelp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputNISN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printStruk = new System.Drawing.Printing.PrintDocument();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistoriSPP = new System.Windows.Forms.DataGridView();
            this.TanggalBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBayarSPP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKembalian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCash)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriSPP)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBayarSPP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputTotalBayar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.inputKembalian);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.inputCash);
            this.groupBox1.Controls.Add(this.inputTanggalBayar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputPetugas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.inputBulan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.inputNominal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputTahun);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 338);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pembayaran SPP";
            // 
            // inputTotalBayar
            // 
            this.inputTotalBayar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTotalBayar.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputTotalBayar.Location = new System.Drawing.Point(264, 136);
            this.inputTotalBayar.Name = "inputTotalBayar";
            this.inputTotalBayar.ReadOnly = true;
            this.inputTotalBayar.Size = new System.Drawing.Size(236, 22);
            this.inputTotalBayar.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(264, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Total Bayar";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(167, 177);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 32);
            this.btnTambah.TabIndex = 47;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(264, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Kembalian";
            // 
            // inputKembalian
            // 
            this.inputKembalian.Enabled = false;
            this.inputKembalian.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputKembalian.Location = new System.Drawing.Point(267, 236);
            this.inputKembalian.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inputKembalian.Name = "inputKembalian";
            this.inputKembalian.Size = new System.Drawing.Size(233, 22);
            this.inputKembalian.TabIndex = 45;
            this.inputKembalian.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(264, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cash";
            // 
            // inputCash
            // 
            this.inputCash.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputCash.Location = new System.Drawing.Point(267, 185);
            this.inputCash.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inputCash.Name = "inputCash";
            this.inputCash.Size = new System.Drawing.Size(233, 22);
            this.inputCash.TabIndex = 42;
            this.inputCash.ThousandsSeparator = true;
            this.inputCash.ValueChanged += new System.EventHandler(this.inputCash_ValueChanged);
            // 
            // inputTanggalBayar
            // 
            this.inputTanggalBayar.Enabled = false;
            this.inputTanggalBayar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTanggalBayar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputTanggalBayar.Location = new System.Drawing.Point(264, 46);
            this.inputTanggalBayar.Name = "inputTanggalBayar";
            this.inputTanggalBayar.Size = new System.Drawing.Size(236, 22);
            this.inputTanggalBayar.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(264, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tanggal Bayar";
            // 
            // inputPetugas
            // 
            this.inputPetugas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPetugas.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputPetugas.Location = new System.Drawing.Point(264, 90);
            this.inputPetugas.Name = "inputPetugas";
            this.inputPetugas.ReadOnly = true;
            this.inputPetugas.Size = new System.Drawing.Size(236, 22);
            this.inputPetugas.TabIndex = 41;
            this.inputPetugas.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(264, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Petugas";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(425, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "Bayar";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // inputBulan
            // 
            this.inputBulan.FormattingEnabled = true;
            this.inputBulan.Location = new System.Drawing.Point(6, 90);
            this.inputBulan.Name = "inputBulan";
            this.inputBulan.Size = new System.Drawing.Size(236, 21);
            this.inputBulan.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Bulan Bayar";
            // 
            // inputNominal
            // 
            this.inputNominal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNominal.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputNominal.Location = new System.Drawing.Point(6, 136);
            this.inputNominal.Name = "inputNominal";
            this.inputNominal.ReadOnly = true;
            this.inputNominal.Size = new System.Drawing.Size(236, 22);
            this.inputNominal.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nominal";
            // 
            // inputTahun
            // 
            this.inputTahun.FormattingEnabled = true;
            this.inputTahun.Location = new System.Drawing.Point(6, 46);
            this.inputTahun.Name = "inputTahun";
            this.inputTahun.Size = new System.Drawing.Size(236, 21);
            this.inputTahun.TabIndex = 29;
            this.inputTahun.SelectedIndexChanged += new System.EventHandler(this.inputTahun_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tahun";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchSiswa);
            this.groupBox2.Controls.Add(this.inputKelas);
            this.groupBox2.Controls.Add(this.inputAlamat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.inputNoTelp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.inputNama);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.inputNISN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 282);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Siswa";
            // 
            // btnSearchSiswa
            // 
            this.btnSearchSiswa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSiswa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSiswa.ForeColor = System.Drawing.Color.White;
            this.btnSearchSiswa.Location = new System.Drawing.Point(222, 34);
            this.btnSearchSiswa.Name = "btnSearchSiswa";
            this.btnSearchSiswa.Size = new System.Drawing.Size(36, 22);
            this.btnSearchSiswa.TabIndex = 39;
            this.btnSearchSiswa.Text = "...";
            this.btnSearchSiswa.UseVisualStyleBackColor = false;
            this.btnSearchSiswa.Click += new System.EventHandler(this.btnSearchSiswa_Click);
            // 
            // inputKelas
            // 
            this.inputKelas.Enabled = false;
            this.inputKelas.FormattingEnabled = true;
            this.inputKelas.Location = new System.Drawing.Point(6, 132);
            this.inputKelas.Name = "inputKelas";
            this.inputKelas.Size = new System.Drawing.Size(252, 21);
            this.inputKelas.TabIndex = 39;
            // 
            // inputAlamat
            // 
            this.inputAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAlamat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAlamat.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputAlamat.Location = new System.Drawing.Point(6, 222);
            this.inputAlamat.Multiline = true;
            this.inputAlamat.Name = "inputAlamat";
            this.inputAlamat.ReadOnly = true;
            this.inputAlamat.Size = new System.Drawing.Size(252, 42);
            this.inputAlamat.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(6, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alamat";
            // 
            // inputNoTelp
            // 
            this.inputNoTelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNoTelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoTelp.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputNoTelp.Location = new System.Drawing.Point(6, 175);
            this.inputNoTelp.Name = "inputNoTelp";
            this.inputNoTelp.ReadOnly = true;
            this.inputNoTelp.Size = new System.Drawing.Size(252, 22);
            this.inputNoTelp.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nomor Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kelas";
            // 
            // inputNama
            // 
            this.inputNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNama.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNama.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputNama.Location = new System.Drawing.Point(6, 80);
            this.inputNama.Name = "inputNama";
            this.inputNama.ReadOnly = true;
            this.inputNama.Size = new System.Drawing.Size(252, 22);
            this.inputNama.TabIndex = 32;
            this.inputNama.TextChanged += new System.EventHandler(this.inputNama_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nama Siswa";
            // 
            // inputNISN
            // 
            this.inputNISN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNISN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNISN.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputNISN.Location = new System.Drawing.Point(6, 34);
            this.inputNISN.Name = "inputNISN";
            this.inputNISN.Size = new System.Drawing.Size(210, 22);
            this.inputNISN.TabIndex = 30;
            this.inputNISN.TextChanged += new System.EventHandler(this.inputNISN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "NISN";
            // 
            // printStruk
            // 
            this.printStruk.DocumentName = "Struk Pembayaran";
            this.printStruk.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printStruk_BeginPrint);
            this.printStruk.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStruk_PrintPage);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewHistoriSPP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(282, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 282);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histori Pembayaran Siswa";
            // 
            // dataGridViewHistoriSPP
            // 
            this.dataGridViewHistoriSPP.AllowUserToAddRows = false;
            this.dataGridViewHistoriSPP.AllowUserToDeleteRows = false;
            this.dataGridViewHistoriSPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistoriSPP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistoriSPP.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewHistoriSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoriSPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TanggalBayar});
            this.dataGridViewHistoriSPP.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewHistoriSPP.Name = "dataGridViewHistoriSPP";
            this.dataGridViewHistoriSPP.ReadOnly = true;
            this.dataGridViewHistoriSPP.Size = new System.Drawing.Size(638, 245);
            this.dataGridViewHistoriSPP.TabIndex = 38;
            // 
            // TanggalBayar
            // 
            this.TanggalBayar.HeaderText = "Tanggal Bayar";
            this.TanggalBayar.Name = "TanggalBayar";
            this.TanggalBayar.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridViewBayarSPP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(524, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 338);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SPP Yang Ingin Dibayar";
            // 
            // dataGridViewBayarSPP
            // 
            this.dataGridViewBayarSPP.AllowUserToAddRows = false;
            this.dataGridViewBayarSPP.AllowUserToDeleteRows = false;
            this.dataGridViewBayarSPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBayarSPP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBayarSPP.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewBayarSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBayarSPP.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewBayarSPP.Name = "dataGridViewBayarSPP";
            this.dataGridViewBayarSPP.ReadOnly = true;
            this.dataGridViewBayarSPP.Size = new System.Drawing.Size(396, 301);
            this.dataGridViewBayarSPP.TabIndex = 38;
            this.dataGridViewBayarSPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBayarSPP_CellContentClick);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 650);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKembalian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCash)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriSPP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBayarSPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox inputBulan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputTahun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputAlamat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputNoTelp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputNISN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox inputNominal;
        private System.Windows.Forms.ComboBox inputKelas;
        private System.Windows.Forms.Button btnSearchSiswa;
        private System.Drawing.Printing.PrintDocument printStruk;
        private System.Windows.Forms.DateTimePicker inputTanggalBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPetugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown inputCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown inputKembalian;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewHistoriSPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalBayar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBayarSPP;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputTotalBayar;
    }
}