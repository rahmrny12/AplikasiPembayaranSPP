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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navSPP = new System.Windows.Forms.Button();
            this.app_title = new System.Windows.Forms.Label();
            this.navKelas = new System.Windows.Forms.Button();
            this.navPetugas = new System.Windows.Forms.Button();
            this.navTransaksi = new System.Windows.Forms.Button();
            this.navSiswa = new System.Windows.Forms.Button();
            this.navHistori = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(162, 681);
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
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.navSPP);
            this.panel1.Controls.Add(this.app_title);
            this.panel1.Controls.Add(this.navKelas);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.navPetugas);
            this.panel1.Controls.Add(this.navTransaksi);
            this.panel1.Controls.Add(this.navSiswa);
            this.panel1.Controls.Add(this.navHistori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 726);
            this.panel1.TabIndex = 2;
            // 
            // navSPP
            // 
            this.navSPP.BackColor = System.Drawing.Color.SteelBlue;
            this.navSPP.FlatAppearance.BorderSize = 0;
            this.navSPP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navSPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSPP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSPP.ForeColor = System.Drawing.Color.White;
            this.navSPP.Image = global::AplikasiPembayaranSPP.Properties.Resources.icons8_calendar_31_24;
            this.navSPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSPP.Location = new System.Drawing.Point(0, 385);
            this.navSPP.Name = "navSPP";
            this.navSPP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navSPP.Size = new System.Drawing.Size(252, 45);
            this.navSPP.TabIndex = 19;
            this.navSPP.Text = "    Data SPP";
            this.navSPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navSPP.UseVisualStyleBackColor = false;
            this.navSPP.Click += new System.EventHandler(this.navSPP_Click);
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_title.ForeColor = System.Drawing.Color.White;
            this.app_title.Location = new System.Drawing.Point(30, 21);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(180, 50);
            this.app_title.TabIndex = 3;
            this.app_title.Text = "APLIKASI\r\nPEMBAYARAN SPP";
            this.app_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // navKelas
            // 
            this.navKelas.BackColor = System.Drawing.Color.SteelBlue;
            this.navKelas.FlatAppearance.BorderSize = 0;
            this.navKelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navKelas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navKelas.ForeColor = System.Drawing.Color.White;
            this.navKelas.Image = global::AplikasiPembayaranSPP.Properties.Resources.icons8_school_24;
            this.navKelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navKelas.Location = new System.Drawing.Point(0, 331);
            this.navKelas.Name = "navKelas";
            this.navKelas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navKelas.Size = new System.Drawing.Size(252, 45);
            this.navKelas.TabIndex = 18;
            this.navKelas.Text = "    Data Kelas";
            this.navKelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navKelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navKelas.UseVisualStyleBackColor = false;
            this.navKelas.Click += new System.EventHandler(this.navKelas_Click);
            // 
            // navPetugas
            // 
            this.navPetugas.BackColor = System.Drawing.Color.SteelBlue;
            this.navPetugas.FlatAppearance.BorderSize = 0;
            this.navPetugas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPetugas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPetugas.ForeColor = System.Drawing.Color.White;
            this.navPetugas.Image = global::AplikasiPembayaranSPP.Properties.Resources.icons8_security_guard_24;
            this.navPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPetugas.Location = new System.Drawing.Point(0, 278);
            this.navPetugas.Name = "navPetugas";
            this.navPetugas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navPetugas.Size = new System.Drawing.Size(252, 45);
            this.navPetugas.TabIndex = 17;
            this.navPetugas.Text = "    Data Petugas";
            this.navPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPetugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navPetugas.UseVisualStyleBackColor = false;
            this.navPetugas.Click += new System.EventHandler(this.navPetugas_Click);
            // 
            // navTransaksi
            // 
            this.navTransaksi.BackColor = System.Drawing.Color.SteelBlue;
            this.navTransaksi.FlatAppearance.BorderSize = 0;
            this.navTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTransaksi.ForeColor = System.Drawing.Color.White;
            this.navTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("navTransaksi.Image")));
            this.navTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navTransaksi.Location = new System.Drawing.Point(0, 104);
            this.navTransaksi.Name = "navTransaksi";
            this.navTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navTransaksi.Size = new System.Drawing.Size(252, 45);
            this.navTransaksi.TabIndex = 14;
            this.navTransaksi.Text = "    Entri Transaksi";
            this.navTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navTransaksi.UseVisualStyleBackColor = false;
            this.navTransaksi.Click += new System.EventHandler(this.navTransaksi_Click);
            // 
            // navSiswa
            // 
            this.navSiswa.BackColor = System.Drawing.Color.SteelBlue;
            this.navSiswa.FlatAppearance.BorderSize = 0;
            this.navSiswa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSiswa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSiswa.ForeColor = System.Drawing.Color.White;
            this.navSiswa.Image = global::AplikasiPembayaranSPP.Properties.Resources.icons8_student_male_24;
            this.navSiswa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSiswa.Location = new System.Drawing.Point(0, 225);
            this.navSiswa.Name = "navSiswa";
            this.navSiswa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navSiswa.Size = new System.Drawing.Size(252, 45);
            this.navSiswa.TabIndex = 16;
            this.navSiswa.Text = "    Data Siswa";
            this.navSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navSiswa.UseVisualStyleBackColor = false;
            this.navSiswa.Click += new System.EventHandler(this.navSiswa_Click);
            // 
            // navHistori
            // 
            this.navHistori.BackColor = System.Drawing.Color.SteelBlue;
            this.navHistori.FlatAppearance.BorderSize = 0;
            this.navHistori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.navHistori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navHistori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navHistori.ForeColor = System.Drawing.Color.White;
            this.navHistori.Image = global::AplikasiPembayaranSPP.Properties.Resources.icons8_transaction_24;
            this.navHistori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHistori.Location = new System.Drawing.Point(0, 158);
            this.navHistori.Name = "navHistori";
            this.navHistori.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navHistori.Size = new System.Drawing.Size(252, 45);
            this.navHistori.TabIndex = 15;
            this.navHistori.Text = "    Histori Pembayaran";
            this.navHistori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHistori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navHistori.UseVisualStyleBackColor = false;
            this.navHistori.Click += new System.EventHandler(this.navHistori_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.labelFormTitle);
            this.panel8.Controls.Add(this.labelLevel);
            this.panel8.Controls.Add(this.labelName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(252, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1118, 80);
            this.panel8.TabIndex = 3;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.ForeColor = System.Drawing.Color.White;
            this.labelFormTitle.Location = new System.Drawing.Point(20, 22);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(0, 21);
            this.labelFormTitle.TabIndex = 20;
            this.labelFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(982, 44);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(122, 17);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "Level";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoEllipsis = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(831, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(273, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Nama Petugas";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(252, 80);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1118, 646);
            this.panelForm.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 681);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button navTransaksi;
        private System.Windows.Forms.Button navHistori;
        private System.Windows.Forms.Button navSPP;
        private System.Windows.Forms.Button navKelas;
        private System.Windows.Forms.Button navPetugas;
        private System.Windows.Forms.Button navSiswa;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Button btnExit;
    }
}