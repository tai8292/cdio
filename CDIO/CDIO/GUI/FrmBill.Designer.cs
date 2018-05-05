namespace CDIO.GUI
{
    partial class FrmBill
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
            this.reportBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportBill
            // 
            this.reportBill.ActiveViewIndex = -1;
            this.reportBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBill.Location = new System.Drawing.Point(0, 0);
            this.reportBill.Name = "reportBill";
            this.reportBill.Size = new System.Drawing.Size(1117, 590);
            this.reportBill.TabIndex = 0;
            this.reportBill.Load += new System.EventHandler(this.reportBill_Load);
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.reportBill);
            this.Name = "FrmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrpBill";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportBill;
    }
}