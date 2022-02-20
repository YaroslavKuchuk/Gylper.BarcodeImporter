using Gylper.BarcodeImporter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                var lines = GetDataFromFile(ofdCsvFile.FileName);

                lblRecordsAmount.Visible = true;
                lblRecordsAmount.Text = $"Записей прочитано: {lines.Count()}";

                SaveData(lines);

                MessageBox.Show("Импорт завершен!");
            }
        }

        private string[] GetDataFromFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }

        private void SaveData(string[] lines)
        {
            var ctx = new FitnessEntities();

            using (var connection
                = new SqlConnection(ctx.Database.Connection.ConnectionString))
            {
                connection.Open();

                foreach (var line in lines)
                {
                    var commandSql
                        = $"INSERT INTO Barcodes ([Barcode]) VALUES('{line}')";

                    var command
                        = new SqlCommand(commandSql, connection);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
