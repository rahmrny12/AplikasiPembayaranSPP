namespace AplikasiPembayaranSPP
{
    partial class FormLaporan
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
            this.components = new System.ComponentModel.Container();
            this.viewHistoriPembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UKK_PEMBAYARAN_SPPDataSet = new AplikasiPembayaranSPP.DB_UKK_PEMBAYARAN_SPPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewHistoriPembayaranTableAdapter = new AplikasiPembayaranSPP.DB_UKK_PEMBAYARAN_SPPDataSetTableAdapters.ViewHistoriPembayaranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewHistoriPembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UKK_PEMBAYARAN_SPPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewHistoriPembayaranBindingSource
            // 
            this.viewHistoriPembayaranBindingSource.DataMember = "ViewHistoriPembayaran";
            this.viewHistoriPembayaranBindingSource.DataSource = this.dB_UKK_PEMBAYARAN_SPPDataSet;
            // 
            // dB_UKK_PEMBAYARAN_SPPDataSet
            // 
            this.dB_UKK_PEMBAYARAN_SPPDataSet.DataSetName = "DB_UKK_PEMBAYARAN_SPPDataSet";
            this.dB_UKK_PEMBAYARAN_SPPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AplikasiPembayaranSPP.ReportRiwayatTransaksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewHistoriPembayaranTableAdapter
            // 
            this.viewHistoriPembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewHistoriPembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UKK_PEMBAYARAN_SPPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DB_UKK_PEMBAYARAN_SPPDataSet dB_UKK_PEMBAYARAN_SPPDataSet;
        private System.Windows.Forms.BindingSource viewHistoriPembayaranBindingSource;
        private DB_UKK_PEMBAYARAN_SPPDataSetTableAdapters.ViewHistoriPembayaranTableAdapter viewHistoriPembayaranTableAdapter;
    }
}