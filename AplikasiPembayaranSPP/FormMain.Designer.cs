namespace AplikasiPembayaranSPP
{
    partial class FormMain
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navHistori = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.navKelas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.navTransaksi = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.navSPP = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.navPetugas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.navSiswa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.app_title = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.navHistori.SuspendLayout();
            this.navKelas.SuspendLayout();
            this.navTransaksi.SuspendLayout();
            this.navSPP.SuspendLayout();
            this.navPetugas.SuspendLayout();
            this.navSiswa.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(11, 493);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.navHistori);
            this.panel1.Controls.Add(this.navKelas);
            this.panel1.Controls.Add(this.navTransaksi);
            this.panel1.Controls.Add(this.navSPP);
            this.panel1.Controls.Add(this.navPetugas);
            this.panel1.Controls.Add(this.navSiswa);
            this.panel1.Controls.Add(this.app_title);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 538);
            this.panel1.TabIndex = 2;
            // 
            // navHistori
            // 
            this.navHistori.BackColor = System.Drawing.Color.Azure;
            this.navHistori.Controls.Add(this.label);
            this.navHistori.Location = new System.Drawing.Point(0, 162);
            this.navHistori.Name = "navHistori";
            this.navHistori.Size = new System.Drawing.Size(245, 45);
            this.navHistori.TabIndex = 13;
            this.navHistori.Click += new System.EventHandler(this.navHistori_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(59, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Histori Pembayaran";
            // 
            // navKelas
            // 
            this.navKelas.BackColor = System.Drawing.Color.Azure;
            this.navKelas.Controls.Add(this.label4);
            this.navKelas.Location = new System.Drawing.Point(0, 336);
            this.navKelas.Name = "navKelas";
            this.navKelas.Size = new System.Drawing.Size(245, 45);
            this.navKelas.TabIndex = 8;
            this.navKelas.Click += new System.EventHandler(this.navKelas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Kelas";
            // 
            // navTransaksi
            // 
            this.navTransaksi.BackColor = System.Drawing.Color.Azure;
            this.navTransaksi.Controls.Add(this.label5);
            this.navTransaksi.Location = new System.Drawing.Point(0, 109);
            this.navTransaksi.Name = "navTransaksi";
            this.navTransaksi.Size = new System.Drawing.Size(245, 45);
            this.navTransaksi.TabIndex = 12;
            this.navTransaksi.Click += new System.EventHandler(this.navTransaksi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Entri Transaksi";
            // 
            // navSPP
            // 
            this.navSPP.BackColor = System.Drawing.Color.Azure;
            this.navSPP.Controls.Add(this.label6);
            this.navSPP.Location = new System.Drawing.Point(0, 390);
            this.navSPP.Name = "navSPP";
            this.navSPP.Size = new System.Drawing.Size(245, 45);
            this.navSPP.TabIndex = 9;
            this.navSPP.Click += new System.EventHandler(this.navSPP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data SPP";
            // 
            // navPetugas
            // 
            this.navPetugas.BackColor = System.Drawing.Color.Azure;
            this.navPetugas.Controls.Add(this.label3);
            this.navPetugas.Location = new System.Drawing.Point(0, 283);
            this.navPetugas.Name = "navPetugas";
            this.navPetugas.Size = new System.Drawing.Size(245, 45);
            this.navPetugas.TabIndex = 7;
            this.navPetugas.Click += new System.EventHandler(this.navPetugas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Petugas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navSiswa
            // 
            this.navSiswa.BackColor = System.Drawing.Color.Azure;
            this.navSiswa.Controls.Add(this.label2);
            this.navSiswa.Location = new System.Drawing.Point(0, 230);
            this.navSiswa.Name = "navSiswa";
            this.navSiswa.Size = new System.Drawing.Size(245, 45);
            this.navSiswa.TabIndex = 6;
            this.navSiswa.Click += new System.EventHandler(this.navSiswa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Siswa";
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_title.ForeColor = System.Drawing.Color.White;
            this.app_title.Location = new System.Drawing.Point(45, 21);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(162, 50);
            this.app_title.TabIndex = 3;
            this.app_title.Text = "Aplikasi\r\nPembayaran SPP";
            this.app_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.labelLevel);
            this.panel8.Controls.Add(this.labelName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(252, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(683, 71);
            this.panel8.TabIndex = 3;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(10, 34);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(42, 17);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "Level";
            // 
            // labelName
            // 
            this.labelName.AutoEllipsis = true;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(8, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Nama Petugas";
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(252, 71);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(683, 467);
            this.panelForm.TabIndex = 4;
            this.panelForm.Click += new System.EventHandler(this.panelForm_Click);
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navHistori.ResumeLayout(false);
            this.navHistori.PerformLayout();
            this.navKelas.ResumeLayout(false);
            this.navKelas.PerformLayout();
            this.navTransaksi.ResumeLayout(false);
            this.navTransaksi.PerformLayout();
            this.navSPP.ResumeLayout(false);
            this.navSPP.PerformLayout();
            this.navPetugas.ResumeLayout(false);
            this.navPetugas.PerformLayout();
            this.navSiswa.ResumeLayout(false);
            this.navSiswa.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.Panel navSiswa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel navKelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel navSPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel navPetugas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel navHistori;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel navTransaksi;
        private System.Windows.Forms.Label label5;
    }
}