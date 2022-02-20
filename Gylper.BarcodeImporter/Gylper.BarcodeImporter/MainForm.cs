using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gylper.BarcodeImporter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdCsvFile.ShowDialog() == DialogResult.OK)
            {
                int count = 100;

                lblRecordsAmount.Visible = true;
                lblRecordsAmount.Text = $"Записей прочитано: {count}";
            }
        }
    }
}
