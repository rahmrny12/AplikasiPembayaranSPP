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
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHistori = new System.Windows.Forms.DataGridView();
            this.btnPrintLaporan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistori)).BeginInit();
            this.SuspendLayout();
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Location = new System.Drawing.Point(616, 55);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(172, 20);
            this.inputSearch.TabIndex = 5;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(558, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search :";
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
            this.dataGridViewHistori.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewHistori.Name = "dataGridViewHistori";
            this.dataGridViewHistori.ReadOnly = true;
            this.dataGridViewHistori.Size = new System.Drawing.Size(776, 211);
            this.dataGridViewHistori.TabIndex = 3;
            // 
            // btnPrintLaporan
            // 
            this.btnPrintLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLaporan.Location = new System.Drawing.Point(650, 298);
            this.btnPrintLaporan.Name = "btnPrintLaporan";
            this.btnPrintLaporan.Size = new System.Drawing.Size(138, 43);
            this.btnPrintLaporan.TabIndex = 0;
            this.btnPrintLaporan.Text = "Cetak Laporan";
            this.btnPrintLaporan.UseVisualStyleBackColor = true;
            this.btnPrintLaporan.Click += new System.EventHandler(this.btnPrintLaporan_Click);
            // 
            // FormRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
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

        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHistori;
        private System.Windows.Forms.Button btnPrintLaporan;
    }
}