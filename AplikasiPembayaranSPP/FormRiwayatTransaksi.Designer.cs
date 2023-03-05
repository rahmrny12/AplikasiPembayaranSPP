namespace AplikasiPembayaranSPP
{
    partial class FormRiwayatTransaksi
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
            this.dataGridViewHistori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.btnPrintLaporan = new System.Windows.Forms.Button();
            this.inputTahun = new System.Windows.Forms.ComboBox();
            this.inputPetugas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputKelas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTglAwal = new System.Windows.Forms.DateTimePicker();
            this.inputTglAkhir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistori
            // 
            this.dataGridViewHistori.AllowUserToAddRows = false;
            this.dataGridViewHistori.AllowUserToDeleteRows = false;
            this.dataGridViewHistori.AllowUserToOrderColumns = true;
            this.dataGridViewHistori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistori.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewHistori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistori.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewHistori.Name = "dataGridViewHistori";
            this.dataGridViewHistori.ReadOnly = true;
            this.dataGridViewHistori.Size = new System.Drawing.Size(904, 244);
            this.dataGridViewHistori.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(499, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cari berdasarkan nama siswa dan NISN :";
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Location = new System.Drawing.Point(744, 109);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(172, 20);
            this.inputSearch.TabIndex = 5;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // btnPrintLaporan
            // 
            this.btnPrintLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLaporan.Location = new System.Drawing.Point(778, 385);
            this.btnPrintLaporan.Name = "btnPrintLaporan";
            this.btnPrintLaporan.Size = new System.Drawing.Size(138, 43);
            this.btnPrintLaporan.TabIndex = 0;
            this.btnPrintLaporan.Text = "Cetak Laporan";
            this.btnPrintLaporan.UseVisualStyleBackColor = true;
            this.btnPrintLaporan.Click += new System.EventHandler(this.btnPrintLaporan_Click);
            // 
            // inputTahun
            // 
            this.inputTahun.FormattingEnabled = true;
            this.inputTahun.Location = new System.Drawing.Point(13, 29);
            this.inputTahun.Name = "inputTahun";
            this.inputTahun.Size = new System.Drawing.Size(154, 21);
            this.inputTahun.TabIndex = 6;
            this.inputTahun.SelectedIndexChanged += new System.EventHandler(this.inputTahun_SelectedIndexChanged);
            // 
            // inputPetugas
            // 
            this.inputPetugas.FormattingEnabled = true;
            this.inputPetugas.Location = new System.Drawing.Point(175, 29);
            this.inputPetugas.Name = "inputPetugas";
            this.inputPetugas.Size = new System.Drawing.Size(154, 21);
            this.inputPetugas.TabIndex = 7;
            this.inputPetugas.SelectedIndexChanged += new System.EventHandler(this.inputNamaPetugas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tahun :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Petugas :";
            // 
            // inputKelas
            // 
            this.inputKelas.FormattingEnabled = true;
            this.inputKelas.Location = new System.Drawing.Point(337, 29);
            this.inputKelas.Name = "inputKelas";
            this.inputKelas.Size = new System.Drawing.Size(154, 21);
            this.inputKelas.TabIndex = 10;
            this.inputKelas.SelectedIndexChanged += new System.EventHandler(this.inputKelas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kelas :";
            // 
            // inputTglAwal
            // 
            this.inputTglAwal.CustomFormat = "dd/MMM/yyyy";
            this.inputTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputTglAwal.Location = new System.Drawing.Point(13, 66);
            this.inputTglAwal.Name = "inputTglAwal";
            this.inputTglAwal.Size = new System.Drawing.Size(154, 20);
            this.inputTglAwal.TabIndex = 12;
            this.inputTglAwal.Value = new System.DateTime(2023, 1, 1, 18, 51, 0, 0);
            this.inputTglAwal.ValueChanged += new System.EventHandler(this.inputTglAwal_ValueChanged);
            // 
            // inputTglAkhir
            // 
            this.inputTglAkhir.CustomFormat = "dd/MMM/yyyy";
            this.inputTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputTglAkhir.Location = new System.Drawing.Point(221, 66);
            this.inputTglAkhir.Name = "inputTglAkhir";
            this.inputTglAkhir.Size = new System.Drawing.Size(154, 20);
            this.inputTglAkhir.TabIndex = 13;
            this.inputTglAkhir.ValueChanged += new System.EventHandler(this.inputTglAkhir_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sampai";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(404, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Filter\r\n";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 438);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputTglAkhir);
            this.Controls.Add(this.inputTglAwal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputKelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPetugas);
            this.Controls.Add(this.inputTahun);
            this.Controls.Add(this.btnPrintLaporan);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHistori);
            this.Name = "FormRiwayatTransaksi";
            this.Text = "FormRiwayatTransaksi";
            this.Load += new System.EventHandler(this.FormRiwayatTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button btnPrintLaporan;
        private System.Windows.Forms.ComboBox inputTahun;
        private System.Windows.Forms.ComboBox inputPetugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputKelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker inputTglAwal;
        private System.Windows.Forms.DateTimePicker inputTglAkhir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
    }
}