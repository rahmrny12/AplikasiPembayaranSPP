namespace AplikasiPembayaranSPP
{
    partial class FormCariSiswa
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
            this.dataGridViewSiswa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.inputSearch.Location = new System.Drawing.Point(216, 47);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(181, 22);
            this.inputSearch.TabIndex = 32;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputNISN_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cari berdasarkan NISN, Nama Siswa...";
            // 
            // dataGridViewSiswa
            // 
            this.dataGridViewSiswa.AllowUserToAddRows = false;
            this.dataGridViewSiswa.AllowUserToDeleteRows = false;
            this.dataGridViewSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSiswa.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiswa.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewSiswa.Name = "dataGridViewSiswa";
            this.dataGridViewSiswa.ReadOnly = true;
            this.dataGridViewSiswa.Size = new System.Drawing.Size(385, 175);
            this.dataGridViewSiswa.TabIndex = 34;
            this.dataGridViewSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiswa_CellContentClick);
            this.dataGridViewSiswa.DoubleClick += new System.EventHandler(this.dataGridViewSiswa_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cari Siswa";
            // 
            // FormCariSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSiswa);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.label1);
            this.Name = "FormCariSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCariSiswa";
            this.Load += new System.EventHandler(this.FormCariSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSiswa;
        private System.Windows.Forms.Label label2;
    }
}