namespace AplikasiPembayaranSPP
{
    partial class FormCetakStruk
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
            this.reportViewerStruk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewerStruk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerStruk.LocalReport.ReportEmbeddedResource = "AplikasiPembayaranSPP.ReportCetakStruk.rdlc";
            this.reportViewerStruk.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStruk.Name = "reportViewer1";
            this.reportViewerStruk.ServerReport.BearerToken = null;
            this.reportViewerStruk.Size = new System.Drawing.Size(800, 450);
            this.reportViewerStruk.TabIndex = 0;
            // 
            // FormCetakStruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerStruk);
            this.Name = "FormCetakStruk";
            this.Text = "FormCetakStruk";
            this.Load += new System.EventHandler(this.FormCetakStruk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStruk;
    }
}