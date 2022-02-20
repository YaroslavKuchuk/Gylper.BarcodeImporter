namespace Gylper.BarcodeImporter
{
    partial class MainForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdCsvFile = new System.Windows.Forms.OpenFileDialog();
            this.lblRecordsAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(93, 75);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(151, 43);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ofdCsvFile
            // 
            this.ofdCsvFile.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // lblRecordsAmount
            // 
            this.lblRecordsAmount.AutoSize = true;
            this.lblRecordsAmount.Location = new System.Drawing.Point(90, 144);
            this.lblRecordsAmount.Name = "lblRecordsAmount";
            this.lblRecordsAmount.Size = new System.Drawing.Size(0, 17);
            this.lblRecordsAmount.TabIndex = 1;
            this.lblRecordsAmount.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 273);
            this.Controls.Add(this.lblRecordsAmount);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт карточек";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdCsvFile;
        private System.Windows.Forms.Label lblRecordsAmount;
    }
}

